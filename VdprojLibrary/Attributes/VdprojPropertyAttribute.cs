namespace SetupProjectHelper.VdprojLibrary.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class VdprojPropertyAttribute : Attribute
{
    public string Key { get; }
    public VdprojPropertyAttribute(string key) => Key = key;
}