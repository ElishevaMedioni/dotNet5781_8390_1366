using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_8390_1366
{
    public class BusLine //: IComparable
    {
        public enum Area { North = 1, South, Center, Jerusalem };

        //fields
        protected int busLineNum;
        private BusStation firstStation;
        private BusStation lastStation;
        private string area = "";
        private List<BusStation> busStationLst;
        private static int busNum = 0;


        public override string ToString()
        {
            string s = "Bus number #" + busLineNum + " \tArea: " + area;
            return s.ToString();
            //+ "\nFirst Station: " + FirstStation + "\nLast Station: " + LastStation
        }

        public BusLine()
        {
            busNum++;
            busLineNum += busNum;
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


        public BusLine(string myArea)
        {
            busNum++;
            busLineNum += busNum;
            area = myArea;
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

        public List<BusStation> SubRoute(int busSKey1, int busSKey2)
        {
            List<BusStation> subRoute = new List<BusStation>();
            subRoute = busStationLst;
            int count = subRoute.Count;
            int index1 = busStationLst.FindIndex(x => x.GetBusStationKey == busSKey1);
            int index2 = busStationLst.FindIndex(x => x.GetBusStationKey == busSKey2);
            subRoute.RemoveRange(0, index1);
            subRoute.RemoveRange(index2+1 , count-index2);
            return subRoute;
        }

        public void setTheRoute(BusStation b1, BusStation b2, BusStation b3, BusStation b4)
        {
            busStationLst.Add(b1);
            busStationLst.Add(b2);
            busStationLst.Add(b3);
            busStationLst.Add(b4);
            b1.addThebusToTheStation(this);
            b2.addThebusToTheStation(this);
            b3.addThebusToTheStation(this);
            b4.addThebusToTheStation(this);
        }

        //methods
        static public bool ExistStation(List<BusStation> myBusStationLst, int myBusStationKey)
        {
            return myBusStationLst.Exists(x => x.GetBusStationKey == myBusStationKey);
        }

        
         public void addStationToTheEndOfATrip(BusStation myBusStation) //pb qd je la met en static (la func)
        {
            busStationLst.Add(myBusStation);
            myBusStation.addThebusToTheStation(this);
        }


        public void addStationToTheBeginningOfATrip(BusStation myBusStation)
        {
            busStationLst.Insert(0, myBusStation);
            myBusStation.addThebusToTheStation(this);
        }

        public void addStationInTheMiddleOfATrip(BusStation myBusStation, int index)
        {
            busStationLst.Insert(index, myBusStation);
            myBusStation.addThebusToTheStation(this);
        }

        
        public void deleteStationToTheTrip(int myBusStationKey)
        {
            if (ExistStation(busStationLst, myBusStationKey))
                busStationLst.Remove(busStationLst.Find(x => x.GetBusStationKey == myBusStationKey));
            else
                Console.WriteLine("This Bus Station Number doesn't exist in the system");
        }


        public bool searchStationInATrip(int myBusStationKey)
        {
            return busStationLst.Exists(x => x.GetBusStationKey == myBusStationKey);
                
        }

        public int FindIndexOfAStationInTheRoute(int myBusStationKey)
        {
            return busStationLst.FindIndex(x => x.GetBusStationKey == myBusStationKey);
        }


      

        //int IComparable.CompareTo(object obj)   // ecrire foncion compare
        //{
        //    BusLine c = (BusLine)obj;
        //    return String.Compare(this.make, c.make);
        //}

    }
   
}
