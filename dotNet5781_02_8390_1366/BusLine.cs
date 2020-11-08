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
        public enum Area { North=1, South, Center, Jerusalem };


        //fields
        protected int busLineNum= 0;
        private BusStation firstStation;
        private BusStation lastStation;
        private string area;
        private List<BusStation> busStationLst;

        public override string ToString()
        {
            string s = "Bus number #" + busLineNum + " \n Area" + area;
            return s.ToString();
        }

        public BusLine()
        {
            busLineNum += 1;
            Console.WriteLine("Please choose an area for your bus");
            Console.WriteLine("Tap 1 for the north, 2 for the south, 3 for the center, 4 for Jerusalem ");
            string s = Console.ReadLine();
            int choice;
            int.TryParse(s, out choice);
            switch (choice)
            {
                case 1:
                    area = "North";
                    break;
                case 2:
                    area = "South";
                    break;
                case 3:
                    area = "Center";
                    break;
                case 4:
                    area = "Jerusalem";
                    break;
                default:
                    Console.WriteLine("no such option"); 
                    break;
            }

            busStationLst = new List<BusStation>();

        }
         

        //properties fields

        public int GetBusLineNum
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

        static public bool ExistStation(List<BusStation> myBusStationLst, int myBusStationKey)
        {
            return myBusStationLst.Exists(x => x.GetbusStationKey == myBusStationKey);
        }

        public void addStationToTheTrip(BusStation myBusStation) //pb qd je la met en static (la func)
        {
            busStationLst.Add(myBusStation);
        }

        public void deleteStationToTheTrip(int myBusStationKey)
        {
            if (ExistStation(busStationLst, myBusStationKey))
                busStationLst.Remove(busStationLst.Find(x => x.GetbusStationKey == myBusStationKey));
            else
                Console.WriteLine("This Bus Station Number doesn't exist in the system");
        }

        //public List<BusStation> 


        int IComparable.CompareTo(object obj)   // ecrire foncion compare
        {
            BusLine c = (BusLine)obj;
            return String.Compare(this.make, c.make);
        }

    }
   
}
