using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Hierarchy
{
    [VdprojNode("Hierarchy")]
    public class HierarchyNode
    {
        [VdprojNode("Entry")]
        public List<HierarchyEntry> HierarchyEntries { get; set; } = new();

        public override string ToString() => $"Hierarchy: {HierarchyEntries.Count} entries";
    }
}
