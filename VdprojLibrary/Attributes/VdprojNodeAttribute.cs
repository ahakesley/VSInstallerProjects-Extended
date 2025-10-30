namespace SetupProjectHelper.VdprojLibrary.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class VdprojNodeAttribute : Attribute
    {
        public string NodeName { get; init; }

        public VdprojNodeAttribute(string nodeName)
        {
        NodeName = nodeName;
    }
}
}
