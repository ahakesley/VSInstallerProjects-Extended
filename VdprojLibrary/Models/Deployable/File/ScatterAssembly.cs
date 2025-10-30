
using System.Security.Permissions;
using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable
{
    [VdprojNode("")]
    [UseNodeName]
    public class ScatterAssembly
    {
        public string NodeName { get; set; } = string.Empty;

        [VdprojProperty("Name")] 
        public string Name { get; set; } = string.Empty;

        [VdprojProperty("Attributes")]
        public int Attributes { get; set; } = -1;

        public override string ToString() => NodeName;
    }

    [VdprojNode("ScatterAssemblies")]
    public class ScatterAssemblyNode
    {
        [VdprojNode("")]
        public List<ScatterAssembly> ScatterAssemblies { get; set; } = new();
    }
}
