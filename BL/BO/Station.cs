using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Station 
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public IEnumerable<Line> LinesPassingAtThisStation { get; set; }
       
        public override string ToString()
        {
            string str = "" + Code + " - " + Name ;
            return str;
        }

      
    }
}
