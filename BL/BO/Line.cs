﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Line 
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public Areas Area { get; set; }
        public int FirstStation { get; set; }
        public int LastStation { get; set; }

        public IEnumerable<Station> ListOfStationsInThisLine { get; set; }


        public override string ToString()
        {
            string str = "" + Code ;
            return str;
        }

    
    }
}
