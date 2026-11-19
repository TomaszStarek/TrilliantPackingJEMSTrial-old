using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Data
{
    public class WipStart
    {
        public int RouteStepId { get; set; }
        public string RouteStepName { get; set; }
        public IList<int> WipId { get; set; }
        public object Document { get; set; }
    }
}
