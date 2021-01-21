using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Bus
    {
        public int License { get; set; }
        public DateTime FromDate { get; set; }
        public double TotalTrip { get; set; }
        public double FuelRemain { get; set; }
        public BusStatus Status { get; set; }
        public double GasolineLevel { get; set; }

        public IEnumerable<Bus> ListOfBus { get; set; }
    }
}