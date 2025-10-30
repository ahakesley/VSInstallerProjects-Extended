using System.Runtime.InteropServices.JavaScript;
using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable
{
    [VdprojNode("")]
    [UseNodeName]
    public class CustomActionEntry
    {
        public string NodeName { get; set; } = string.Empty;

        [VdprojProperty("Name")]
        public string Name { get; set; } = string.Empty;

        [VdprojProperty("Condition")]
        public string Condition { get; set; } = string.Empty;

        [VdprojProperty("Object")]
        public string Object { get; set; } = string.Empty;

        [VdprojProperty("FileType")]
        public int FileType { get; set; } = -1;

        [VdprojProperty("InstallAction")]
        public int InstallAction { get; set; } = -1;

        [VdprojProperty("Arguments")]
        public string Arguments { get; set; } = string.Empty;

        [VdprojProperty("EntryPoint")]
        public string EntryPoint { get; set; } = string.Empty;

        [VdprojProperty("Sequence")]
        public int Sequence { get; set; } = -1;

        [VdprojProperty("Identifier")]
        public string Identifier { get; set; } = string.Empty;

        [VdprojProperty("InstallerClass")]
        public bool InstallerClass { get; set; } = false;

        [VdprojProperty("CustomActionData")]
        public string CustomActionData { get; set; } = string.Empty;

        public override string ToString() => NodeName;
    }
}
