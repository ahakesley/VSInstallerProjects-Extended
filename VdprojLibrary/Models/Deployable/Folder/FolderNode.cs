using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable.Folder
{
    [VdprojNode("Folder")]
    public class FolderNode
    {
        [VdprojNode("")]
        public List<FolderEntry> Folders { get; set; } = new();
    }

    [VdprojNode("")]
    [UseNodeName]
    public class FolderEntry
    {
        public string NodeName { get; set; } = string.Empty;

        [VdprojProperty("Name")]
        public string Name { get; set; } = string.Empty;

        [VdprojProperty("AlwaysCreate")]
        public bool AlwaysCreate { get; set; } = false;

        [VdprojProperty("Condition")]
        public string Condition { get; set; } = string.Empty;

        [VdprojProperty("Transitive")]
        public bool Transitive { get; set; } = false;

        [VdprojProperty("Property")]
        public string Property { get; set; } = string.Empty;

        [VdprojNode("Folders")]
        public FolderNode Folders { get; set; } = new();
    }
}
