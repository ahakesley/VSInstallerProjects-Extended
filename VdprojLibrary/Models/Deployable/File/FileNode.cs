using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable
{
    [VdprojNode("File")]
    public class FileNode
    {
        [VdprojNode("")]
        public List<FileEntry> FileEntries { get; set; } = new();
    }
}
