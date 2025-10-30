using System.ComponentModel;
using SetupProjectHelper.VdprojLibrary.Models.Deployable;

namespace SetupProjectHelper.ViewModels;

public class FileEntryViewModel : NotificationObject
{
    private readonly FileEntry _fileEntry;

    public FileEntryViewModel(FileEntry file)
    {
        _fileEntry = file;
    }

    [Browsable(true)]
    public string Name
    {
        get
        {
            return _fileEntry.AssemblyAsmDisplayName.Split(',')[0];
        }
    }

    public string Version
    {
        get
        {
            return GetAssemblyDisplayDetail("Version");
        }
    }

    public string Culture
    {
        get
        {
            return GetAssemblyDisplayDetail("Culture");
        }
    }

    public string PublicKeyToken
    {
        get
        {
            return GetAssemblyDisplayDetail("PublicKeyToken");
        }
    }

    public string ProcessorArchitecture
    {
        get
        {
            return GetAssemblyDisplayDetail("ProcessorArchitecture");
        }
    }

    [Browsable(true)]
    public string SourcePath
    {
        get
        {
            return _fileEntry.SourcePath;
        }
    }

    [Browsable(true)]
    public string Folder
    {
        get
        {
            return _fileEntry.FolderName;
        }
    }

    [Browsable(true)]
    public string Condition
    {
        get
        {
            return _fileEntry.Condition;
        }
    }

    [Browsable(true)]
    public string Dependencies
    {
        get
        {
            return _fileEntry.Dependencies;
        }
    }

    [Browsable(true)]
    public bool Exclude
    {
        get
        {
            return _fileEntry.Exclude;
        }
    }

    private string GetAssemblyDisplayDetail(string partName)
    {
        partName = partName.ToLower();
        string[] assemblyNameParts = _fileEntry.AssemblyAsmDisplayName.Split(',');
        foreach (string part in assemblyNameParts)
        {
            if (part.Contains("=") && part.Trim().ToLower().StartsWith(partName))
            {
                return part.Split('=')[1];
            }
        }

        return string.Empty;
    }
}