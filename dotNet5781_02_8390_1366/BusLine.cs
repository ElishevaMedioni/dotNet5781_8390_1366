﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_8390_1366
{
    public class BusLine : IComparable
    {
      
        //fields
        protected int busLineNum;
        private BusStation firstStation;
        private BusStation lastStation;
        private string area;
        private List<BusStation> busStationLst;

        public override string ToString()
        {
            return base.ToString();
        }


         

        //properties fields

        public int BusLineNum
        {
            get { return busLineNum; }
            set { busLineNum = value; }
        }

        public BusStation FirstStation
        {
           
            get {return busStationLst.First(); }
            set { firstStation = null; } //au moment de la bdika on demandera =null? --> la list est vide
        }

        public BusStation LastStation
        {
            get { return busStationLst.Last(); }
            set { lastStation = null; }
        }

        /*
                public IEnumerator GetEnumerator()
                {
                   // return 
                }
        */

        //methods


        public BusLine()
        {

            List<BusStation> busStationLst = new List<BusStation>;



        }
         public void addStationToTheTrip(BusStation myBusStation) //pb qd je la met en static (la func)
        {
            busStationLst.Add(myBusStation);
        }

        int IComparable.CompareTo(object obj)   // ecrire foncion compare
        {
            BusLine c = (BusLine)obj;
            return String.Compare(this.make, c.make);
        }

    }
   
}
