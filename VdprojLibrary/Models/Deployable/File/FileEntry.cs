using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable;

[VdprojNode("")]
[UseNodeName]
public class FileEntry
{
    public string NodeName { get; set; } = string.Empty;

    [VdprojProperty("AssemblyRegister")]
    public int AssemblyRegister { get; set; } = -1;

    [VdprojProperty("AssemblyIsInGAC")]
    // ReSharper disable once InconsistentNaming
    public bool AssemblyIsInGAC { get; set; } = false; 
        
    [VdprojProperty("AssemblyAsmDisplayName")]
    public string AssemblyAsmDisplayName { get; set; } = string.Empty;

    [VdprojProperty("SourcePath")]
    public string SourcePath { get; set; } = string.Empty;

    [VdprojProperty("TargetName")]
    public string TargetName { get; set; } = string.Empty;

    [VdprojProperty("Tag")]
    public string Tag { get; set; } = string.Empty;

    [VdprojProperty("Folder")]
    public string Folder { get; set; } = string.Empty;

    [VdprojProperty("Condition")]
    public string Condition { get; set; } = string.Empty;

    [VdprojProperty("Transitive")]
    public bool Transitive { get; set; } = false;

    [VdprojProperty("Vital")]
    public bool Vital { get; set; } = false;

    [VdprojProperty("ReadOnly")]
    public bool ReadOnly { get; set; } = false;

    [VdprojProperty("Hidden")]
    public bool Hidden { get; set; } = false;

    [VdprojProperty("System")]
    public bool System { get; set; } = false;

    [VdprojProperty("Permanent")]
    public bool Permanent { get; set; } = false;

    [VdprojProperty("SharedLegacy")]
    public bool SharedLegacy { get; set; } = false;

    [VdprojProperty("PackageAs")]
    public int PackageAs { get; set; } = -1;

    [VdprojProperty("Register")]
    public int Register { get; set; } = -1;

    [VdprojProperty("Exclude")]
    public bool Exclude { get; set; } = false;

    [VdprojProperty("IsDependency")]
    public bool IsDependency { get; set; } = false;

    [VdprojProperty("IsolateTo")]
    public string IsolateTo { get; set; } = string.Empty;

    [VdprojNode("ScatterAssemblies")] 
    public ScatterAssemblyNode ScatterAssemblies { get; set; } = new();

    public override string ToString() => NodeName;

    public string FolderName { get; set; } = string.Empty;

    public string Dependencies { get; set; } = string.Empty;

}