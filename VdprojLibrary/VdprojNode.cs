using SetupProjectHelper.ViewModels;

namespace SetupProjectHelper.VdprojLibrary;

public class VdprojNode
{
    public string Name { get; set; } = string.Empty;
    public Dictionary<string, VdprojProperty> Properties { get; set; } = new();
    public List<VdprojNode> Children { get; set; } = new();

    public override string ToString() => Name;
    
}

public class VdprojProperty
{
    public string Value { get; set; } = string.Empty;
    public VdprojNode? SubProperty { get; set; } = null;
}