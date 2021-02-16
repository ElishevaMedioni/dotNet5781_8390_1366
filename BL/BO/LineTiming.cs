using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LineTiming
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public int LineCode { get; set; }
        public TimeSpan TripStart { get; set; }
        public string LastStation { get; set; }
        public TimeSpan Timing { get; set; }
    }
}
