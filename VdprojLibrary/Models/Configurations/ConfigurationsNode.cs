using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Configurations
{
    [VdprojNode("Configurations")]
    public class ConfigurationsNode
    {
        [VdprojNode("")]
        public List<ConfigurationEntry> ConfigurationEntries { get; set; } = new();
    }
}
