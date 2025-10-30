using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Configurations
{
    [VdprojNode("")]
    public class Bootstrapper
    {
        [VdprojProperty("Enabled")]
        public bool Enabled { get; set; } = false;

        [VdprojProperty("PromptEnabled")]
        public bool PromptEnabled { get; set; } = false;

        [VdprojProperty("PrerequisitesLocation")]
        public short PrerequisitesLocation { get; set; } = -1;

        [VdprojProperty("Url")]
        public string Url { get; set; } = string.Empty;

        [VdprojProperty("ComponentsUrl")]
        public string ComponentsUrl { get; set; } = string.Empty;

        [VdprojNode("Items")]
        public List<BootstrapperItemNode> Items { get; set; } = new();
    }
}
