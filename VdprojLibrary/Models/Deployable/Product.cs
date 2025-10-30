using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable
{
    [VdprojNode("Product")]
    public class Product
    {
        [VdprojProperty("Name")]
        public string Name { get; set; } = string.Empty;

        [VdprojProperty("ProductName")]
        public string ProductName { get; set; } = string.Empty;

        [VdprojProperty("ProductCode")]
        public string ProductCode { get; set; } = string.Empty;

        [VdprojProperty("PackageCode")]
        public string PackageCode { get; set; } = string.Empty;

        [VdprojProperty("UpgradeCode")]
        public string UpgradeCode { get; set; } = string.Empty;

        [VdprojProperty("AspNetVersion")]
        public string AspNetVersion { get; set; } = string.Empty;

        [VdprojProperty("RestartWWWService")]
        public bool RestartWWWService { get; set; } = false;

        [VdprojProperty("RemovePreviousVersions")]
        public bool RemovePreviousVersions { get; set; } = false;

        [VdprojProperty("DetectNewerInstallerVersion")]
        public bool DetectNewerInstalledVersion { get; set; } = false;

        [VdprojProperty("InstallAllUsers")]
        public bool InstallAllUsers { get; set; } = false;

        [VdprojProperty("ProductVersion")]
        public string ProductVersion { get; set; } = string.Empty;

        [VdprojProperty("Manufacturer")]
        public string Manufacturer { get; set; } = string.Empty;

        [VdprojProperty("ARPHELPTELEPHONE")]
        public string ArpHelpTelephone { get; set; } = string.Empty;

        [VdprojProperty("ARPHELPLINK")]
        public string ArpHelpLink { get; set; } = string.Empty;

        [VdprojProperty("Title")]
        public string Title { get; set; } = string.Empty;

        [VdprojProperty("Subject")]
        public string Subject { get; set; } = string.Empty;

        [VdprojProperty("ARPCONTACT")]
        public string ArpContact { get; set; } = string.Empty;

        [VdprojProperty("Keywords")]
        public string Keywords { get; set; } = string.Empty;

        [VdprojProperty("ARPCOMMENTS")]
        public string ArpComments { get; set; } = string.Empty;

        [VdprojProperty("ARPURLINFOABOUT")]
        public string ArpUrlInfoAbout { get; set; } = string.Empty;

        [VdprojProperty("ARPPRODUCTION")]
        public string ArpProduction { get; set; } = string.Empty;

        [VdprojProperty("ARPIconIndex")]
        public int ArpIconIndex { get; set; } = -1;

        [VdprojProperty("SearchPath")]
        public string SearchPath { get; set; } = string.Empty;

        [VdprojProperty("UseSystemSearchPath")]
        public bool UseSystemSearchPath { get; set; } = false;

        [VdprojProperty("TargetPlatform")]
        public int TargetPlatform { get; set; } = -1;

        [VdprojProperty("PreBuildEvent")]
        public string PreBuildEvent { get; set; } = string.Empty;

        [VdprojProperty("PostBuildEvent")]
        public string PostBuildEvent { get; set; } = string.Empty;

        [VdprojProperty("RunPostBuildEvent")]
        public int RunPostBuildEvent { get; set; } = -1;

        public override string ToString() => "Product";

    }
}
