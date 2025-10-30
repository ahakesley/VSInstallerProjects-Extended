using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Configurations
{
    [VdprojNode("")]
    [UseNodeName]
    public class ConfigurationEntry
    {
        public string NodeName { get; set; } = string.Empty; // node name e.g. Debug, Release

        [VdprojProperty("DisplayName")]
        public string DisplayName { get; set; } = string.Empty;

        [VdprojProperty("IsDebugOnly")]
        public bool IsDebugOnly { get; set; } = false;

        [VdprojProperty("IsReleaseOnly")]
        public bool IsReleaseOnly { get; set; } = false;

        [VdprojProperty("OutputFilename")]
        public string OutputFilename { get; set; } = string.Empty;

        [VdprojProperty("PackageFileAs")]
        public int PackageFileAs { get; set; } = -1;

        [VdprojProperty("PackageFileSize")]
        public int PackageFileSize { get; set; } = -1;

        [VdprojProperty("CabType")]
        public int CabType { get; set; } = -1;

        [VdprojProperty("Compression")]
        public int Compression { get; set; } = -1;

        [VdprojProperty("SignOutput")]
        public bool SignOutput { get; set; } = false;

        [VdprojProperty("CertificateFile")]
        public string CertificateFile { get; set; } = string.Empty;

        [VdprojProperty("PrivateKeyFile")]
        public string PrivateKeyFile { get; set; } = string.Empty;

        [VdprojProperty("TimeStampServer")]
        public string TimeStampServer { get; set; } = string.Empty;

        [VdprojProperty("InstallerBootstrapper")]
        public int InstallerBootstrapper { get; set; } = -1;

        [VdprojNode("BootstrapperCfg:*")]
        public Bootstrapper Bootstrapper { get; set; } = new();

        public override string ToString() => NodeName;
    }
}
