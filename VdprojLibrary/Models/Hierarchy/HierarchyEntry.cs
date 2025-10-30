using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Hierarchy
{
    [VdprojNode("Entry")]
    public class HierarchyEntry
    {
        [VdprojProperty("MsmKey")] 
        public string MsmKey { get; set; } = string.Empty; // assembly key

        [VdprojProperty("OwnerKey")] 
        public string OwnerKey { get; set; } = string.Empty; // owner assembly key

        [VdprojProperty("MsmSig")]
        public string MsmSig { get; set; } = string.Empty;
}
}
