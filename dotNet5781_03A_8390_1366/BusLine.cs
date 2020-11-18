using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_03A_8390_1366
{
    public class BusLine 
    {
        public enum Area { North = 1, South, Center, Jerusalem };

        //fields
        protected int busLineNum;
        private BusStation firstStation;
        private BusStation lastStation;
        private string area = "";
        private List<BusStation> busStationLst;
        private static int busNum = 0;
        static Random r = new Random();

        //constructors

        public BusLine() //constructor for a new bus
        {
            busNum++;
            busLineNum += busNum;
            Console.WriteLine("Please choose an area for your bus");
            Console.WriteLine("Tap 1 for the north, 2 for the south, 3 for the center, 4 for Jerusalem ");
            //the user can chose in which area he wants his new bus
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


        public BusLine(string myArea) //constructor for the buses that we initialyse in the beginning of the program
        {
            int number;
            number = r.Next(0, 999);
            busLineNum = number;
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
            set { firstStation = busStationLst.First(); } 
        }

        public BusStation LastStation
        {
            get { return busStationLst.Last(); }
            set { lastStation = busStationLst.Last(); ; }
        }

        public List<BusStation> GetBusStationLst
        {
            get { return busStationLst; }
            set { busStationLst = value; }
        }

        //methods
        public override string ToString()
        {
            string s = "Bus number #" + busLineNum + " \tArea: " + area;
            return s.ToString();
            //+ "\nFirst Station: " + FirstStation + "\nLast Station: " + LastStation
        }

        /// <summary>
        /// Function that receives 2 Bus Stations and returns the sub route
        /// </summary>
        /// <param name="bs1"></param>
        /// <param name="bs2"></param>
        /// <returns>List<BusStation></returns>
        public List<BusStation> SubRoute(BusStation bs1, BusStation bs2)
        {
            List<BusStation> subRoute = new List<BusStation>();
            subRoute = busStationLst;
           
            int index1 = subRoute.IndexOf(bs1);
            int index2 = subRoute.IndexOf(bs2);
            if (index1<index2)
                return subRoute.GetRange(index1, (index2 - index1+1));
            
            else
                return subRoute.GetRange(index2, (index1 - index2+1));
          
        }

        /// <summary>
        /// function that sets 4 bus stations to the route of a bus
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <param name="b3"></param>
        /// <param name="b4"></param>
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

        
         public bool ExistStation(List<BusStation> myBusStationLst, int myBusStationKey)
        {
            return myBusStationLst.Exists(x => x.GetBusStationKey == myBusStationKey);
        }

        
         public void addStationToTheEndOfATrip(BusStation myBusStation) 
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



    }
   
}
