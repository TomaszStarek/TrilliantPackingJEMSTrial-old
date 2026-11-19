using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Data
{
    public class WIPSerialNumber2
    {
        public string SerialNumber { get; set; }
    }

    public class ContainerDetails2
    {
        public string Material { get; set; }
        public string AssemblyNumber { get; set; }
        public string AssemblyRevision { get; set; }
        public string AssemblyVersion { get; set; }
        public int ContainerTotalItems { get; set; }
        public int ContainerMaxCapacity { get; set; }
        public IList<WIPSerialNumber2> WIPSerialNumbers { get; set; }
    }

    public class contentsByWip
    {
        public string Customer { get; set; }
        public string Division { get; set; }
        public string ContainerNumber { get; set; }
        public string ContainerUsageType { get; set; }
        public string ContainerStatus { get; set; }
        public ContainerDetails2 ContainerDetails { get; set; }
    }
}
