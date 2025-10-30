using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Configurations
{
    [VdprojNode("")]
    [UseNodeName]
    public class BootstrapperItem
    {
        public string NodeName { get; set; } = string.Empty;

        [VdprojProperty("Name")]
        public string Name { get; set; } = string.Empty;

        [VdprojProperty("ProductCode")]
        public string ProductCode { get; set; } = string.Empty;

        public override string ToString() => NodeName;
    }

    public class BootstrapperItemNode
    {
        [VdprojNode("")]
        public List<BootstrapperItem> BootstrapperItems { get; set; } = new();
    }
}
