using System.Collections.Generic;

namespace Julio.Francisco.De.Iriarte
{
    public class OrganizationChartViewModel
    {
        public string Name { get; set; }
        public IList<OrganizationChartViewModel> SubItems { get; set; }
    }
}