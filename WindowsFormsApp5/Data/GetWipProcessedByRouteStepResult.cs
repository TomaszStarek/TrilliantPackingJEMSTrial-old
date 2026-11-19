using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Data
{
    public class GetWipProcessedByRouteStepResult
    {
        public class RouteStep
        {
            public int RouteStepID { get; set; }
            public string RouteStepName { get; set; }
            public DateTime RouteStepStartTime { get; set; }
            public DateTime RouteStepEndTime { get; set; }
            public string ResourceName { get; set; }
            public string Operator { get; set; }
            public string OperatorId { get; set; }
            public string Status { get; set; }
        }

        public class Route
        {
            public int RouteID { get; set; }
            public string RouteName { get; set; }
            public IList<RouteStep> RouteSteps { get; set; }
        }

        public class WipItem
        {
            public int WipId { get; set; }
            public string SerialNumber { get; set; }
            public DateTime CreatedOnDateTime { get; set; }
            public int AssemblyId { get; set; }
            public string AssemblyNumber { get; set; }
            public string AssemblyRevision { get; set; }
            public string FamilyName { get; set; }
            public string Customer { get; set; }
            public IList<Route> Routes { get; set; }
        }

        public class Processed
        {
            public IList<WipItem> wipItems { get; set; }
        }
    }
}
