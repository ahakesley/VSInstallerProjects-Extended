using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Configurations
{
    [VdprojNode("InstallerBootstrapper")]
    public class InstallerBootstrapperEntry
    {
        [VdprojProperty("InstallerBootstrapper")]
        public int Setting { get; set; } = -1;

        [VdprojNode("BootstrapperCfg:*")]
        public Bootstrapper Bootstrapper { get; set; } = new();
    }
}
