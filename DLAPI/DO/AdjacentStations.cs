﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class AdjacentStations
    {
        public int Station1 { get; set;  }
        public int Station2 { get; set; }
        public double Distance { get; set; }
        public TimeSpan Time { get; set; }

        public override string ToString()
        {
            return this.ToStringProperty();
            
            //verifier si on fait pas this.ToStringProperty 
        }

    }
}
