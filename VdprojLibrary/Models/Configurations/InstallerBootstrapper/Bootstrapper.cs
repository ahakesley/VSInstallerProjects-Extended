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

        // TODO work out type for PrerequisitesLocation
        [VdprojProperty("PrerequisitesLocation")]
        public object? PrerequisitesLocation { get; set; } = null;

        [VdprojProperty("Url")]
        public string Url { get; set; } = string.Empty;

        [VdprojProperty("ComponentsUrl")]
        public string ComponentsUrl { get; set; } = string.Empty;

        // TODO handle ComponentsUrl.Children
        [VdprojNode("Items")]
        public List<BootstrapperItem> Items { get; set; } = new();
    }
}
