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
    
        public int LineCode { get; set; }
        public TimeSpan Arrival { get; set; }
        public string LastStation { get; set; }
        public int MinutesTillArrival { get; set; }
    }
}
