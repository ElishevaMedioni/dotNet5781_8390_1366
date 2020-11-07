using System;
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
         public void addStationToTheTrip(BusStation myBusStation) //pb qd je la met en static (la func)
        {
            busStationLst.Add(myBusStation);
        }

        public IEnumerator GetEnumerator()
        {
            return _items.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.Values.GetEnumerator();
        }

    }
   
}
