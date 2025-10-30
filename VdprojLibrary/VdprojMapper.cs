using SetupProjectHelper.VdprojLibrary.Attributes;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography;
using SetupProjectHelper.VdprojLibrary.Models.Deployable;
using SetupProjectHelper.VdprojLibrary.Models.Deployable.Folder;

namespace SetupProjectHelper.VdprojLibrary
{
    public static class VdprojMapper
    {
        public static T MapNode<T>(VdprojNode node) where T : new()
        {
            T? instance = new T();
            Type type = typeof(T);

            PropertyInfo[] typeProperties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in typeProperties)
            {
                VdprojPropertyAttribute? propertyAttribute = property.GetCustomAttribute<VdprojPropertyAttribute>();
                if (propertyAttribute != null && node.Properties.TryGetValue(propertyAttribute.Key, out string? rawValue))
                {
                    object converted = Convert.ChangeType(rawValue, property.PropertyType);
                    property.SetValue(instance, converted);
                }
            }

            foreach (PropertyInfo property in typeProperties)
            {
                VdprojNodeAttribute? nodeAttribute = property.GetCustomAttribute<VdprojNodeAttribute>();
                if (nodeAttribute == null) continue;

                List<VdprojNode> matchingChildren = node.Children
                    .Where(c =>
                        string.IsNullOrWhiteSpace(nodeAttribute.NodeName) ||
                        c.Name == nodeAttribute.NodeName ||
                        c.Name.StartsWith(nodeAttribute.NodeName)).ToList();

                if (property.PropertyType.IsGenericType &&
                    property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    Type elementType = property.PropertyType.GetGenericArguments()[0];
                    IList list = (IList)Activator.CreateInstance(property.PropertyType)!;

                    foreach (VdprojNode child in matchingChildren)
                    {
                        MethodInfo mapMethod = typeof(VdprojMapper).GetMethod(nameof(MapNode))!.MakeGenericMethod(elementType);
                        object? mapped = mapMethod.Invoke(null, [child]);
                        list.Add(mapped);
                    }

                    property.SetValue(instance, list);
                }
                else if (matchingChildren.Count > 0)
                {
                    MethodInfo mapMethod =
                        typeof(VdprojMapper).GetMethod(nameof(MapNode))!.MakeGenericMethod(property.PropertyType);
                    object? mapped = mapMethod.Invoke(null, [matchingChildren.First()]);
                    property.SetValue(instance, mapped);

                }
            }

            bool useNodeName = type.GetCustomAttribute<UseNodeNameAttribute>() != null;
            if (useNodeName)
            {
                PropertyInfo? nodeNameProp = type.GetProperty("NodeName");
                if (nodeNameProp != null)
                {
                    nodeNameProp.SetValue(instance, node.Name);
                }
            }

            return instance;
        }

        public static void ResolveAssemblyFileFolderNames(List<FileEntry> files, List<FolderEntry> folders)
        {
            // create dictionary of folder ids to names
            Dictionary<string, string> folderIdToName = new();
            GetFolderIdsToNames(folders, folderIdToName);

            foreach (FileEntry file in files)
            {
                string fileFolderId = file.Folder;
                if (folderIdToName.TryGetValue(fileFolderId, out string? folderName))
                {
                    file.FolderName = folderName;
                }
            }
        }

        private static void GetFolderIdsToNames(List<FolderEntry> folders, Dictionary<string, string> folderIdToName, string parentFolder = "")
        {
            foreach (FolderEntry folder in folders)
            {
                string folderId = folder.NodeName;
                if (folderId.Contains(':'))
                {
                    folderId = folderId.Split(':')[1];
                }

                string folderName = folder.Name;
                if (folderName.StartsWith('#'))
                {
                    folderName = folder.Property;
                }

                if (!string.IsNullOrWhiteSpace(parentFolder))
                {
                    folderName = $"{parentFolder}\\{folderName}";
                }
                folderIdToName.Add(folderId, folderName);

                if (folder.Folders.Folders.Count > 0)
                {
                    GetFolderIdsToNames(folder.Folders.Folders, folderIdToName, folderName);
                }
            }
        }
    }
}