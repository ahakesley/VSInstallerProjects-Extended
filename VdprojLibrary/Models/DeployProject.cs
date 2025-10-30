using SetupProjectHelper.VdprojLibrary.Attributes;
using SetupProjectHelper.VdprojLibrary.Models.Configurations;
using SetupProjectHelper.VdprojLibrary.Models.Deployable;
using SetupProjectHelper.VdprojLibrary.Models.Hierarchy;

namespace SetupProjectHelper.VdprojLibrary.Models
{
    [VdprojNode("DeployProject")]
    public class DeployProject
    {
        [VdprojProperty("VSVersion")] 
        public int VsVersion { get; set; } = -1;

        [VdprojProperty("ProjectType")]
        public string ProjectType { get; set; } = string.Empty;

        [VdprojProperty("IsWebType")] 
        public bool IsWebType { get; set; } = false;

        [VdprojProperty("ProjectName")]
        public string ProjectName { get; set; } = string.Empty;

        [VdprojProperty("LanguageId")] 
        public int LanguageId { get; set; } = -1;

        [VdprojProperty("CodePage")]
        public int CodePage { get; set; } = -1;

        [VdprojProperty("UILanguageId")]
        public int UiLanguageId { get; set; } = -1;

        [VdprojProperty("SccProjectName")]
        public string SccProjectName { get; set; } = string.Empty;

        [VdprojProperty("SccLocalPath")]
        public string SccLocalPath { get; set; } = string.Empty;

        [VdprojProperty("SccAuxPath")]
        public string SccAuxPath { get; set; } = string.Empty;

        [VdprojProperty("SccProvider")]
        public string SccProvider { get; set; } = string.Empty;

        [VdprojNode("Hierarchy")]
        public HierarchyNode Hierarchy { get; set; } = new();

        [VdprojNode("Configurations")]
        public ConfigurationsNode Configurations { get; set; } = new();

        [VdprojNode("Deployable")]
        public DeployableNode Deployable { get; set; } = new();

    }
}
