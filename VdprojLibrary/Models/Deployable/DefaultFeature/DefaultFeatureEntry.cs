using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupProjectHelper.VdprojLibrary.Attributes;

namespace SetupProjectHelper.VdprojLibrary.Models.Deployable.DefaultFeature
{
    [VdprojNode("DefaultFeature")]
    public class DefaultFeatureEntry
    {
        [VdprojProperty("Name")]
        public string Name { get; set; } = string.Empty;

        [VdprojProperty("Title")]
        public string Title { get; set; } = string.Empty;

        [VdprojProperty("Description")]
        public string Description { get; set; } = string.Empty;
    }
}
