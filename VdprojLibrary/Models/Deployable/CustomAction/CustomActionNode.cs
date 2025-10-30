using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable
{
    [VdprojNode("CustomAction")]
    public class CustomActionNode
    {
        [VdprojNode("")]
        public List<CustomActionEntry> CustomActionEntries { get; set; } = new();
    }
}
