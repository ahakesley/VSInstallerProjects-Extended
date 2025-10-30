using SetupProjectHelper.VdprojLibrary.Attributes;
using SetupProjectHelper.VdprojLibrary.Models.Deployable.DefaultFeature;
using SetupProjectHelper.VdprojLibrary.Models.Deployable.Folder;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable
{
    [VdprojNode("Deployable")]
    public class DeployableNode
    {
        [VdprojNode("CustomAction")]
        public CustomActionNode CustomActions { get; set; } = new();

        [VdprojNode("DefaultFeature")]
        public DefaultFeatureEntry DefaultFeature { get; set; } = new();

        [VdprojNode("ExternalPersistence")]
        public ExternalPersistence ExternalPersistence { get; set; } = new();

        [VdprojNode("File")]
        public FileNode Files { get; set; } = new();
        
        [VdprojNode("FileType")]
        public FileType FileType { get; set; } = new();

        [VdprojNode("Folder")]
        public FolderNode Folders { get; set; } = new();

        [VdprojNode("LaunchCondition")]
        public LaunchCondition LaunchCondition { get; set; } = new();

        [VdprojNode("Locator")]
        public Locator Locator { get; set; } = new();

        [VdprojNode("MsiBootstrapper")]
        public MsiBootstrapper MsiBootstrapper { get; set; } = new();

        [VdprojNode("Product")]
        public Product Product { get; set; } = new();

        [VdprojNode("Registry")]
        public Registry Registry { get; set; } = new();

        [VdprojNode("Sequences")]
        public Sequences Sequences { get; set; } = new();

        [VdprojNode("Shortcut")]
        public Shortcut Shortcut { get; set; } = new();

        [VdprojNode("UserInterface")]
        public UserInterface UserInterface { get; set; } = new();

        [VdprojNode("MergeModule")]
        public MergeModule MergeModule { get; set; } = new();

        [VdprojNode("ProjectOutput")]
        public ProjectOutput ProjectOutput { get; set; } = new();
    }

    public class ProjectOutput
    {
    }

    public class MergeModule
    {
    }

    public class UserInterface
    {
    }

    public class Shortcut
    {
    }

    public class Sequences
    {
    }

    public class Registry
    {
    }

    public class MsiBootstrapper
    {
    }

    public class Locator
    {
    }

    public class LaunchCondition
    {
    }

    
    public class FileType
    {
    }

    public class ExternalPersistence
    {
    }
}
