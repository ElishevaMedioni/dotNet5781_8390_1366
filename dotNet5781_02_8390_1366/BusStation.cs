using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Device.Location;



namespace dotNet5781_02_8390_1366
{
    public class BusStation
    {
        //fields
        private int busStationKey;
        protected double latitude;
        protected double longitude;
        protected string address;
        static int countForTheStationKey = 100000;
        static Random r = new Random();
        public List<BusLine> busesPassingAtThisStation;


        //constructors
        public BusStation(string myAddress) //constructor for the 40 bus stations that we initialyse in the beginning of the program
        {

            busStationKey = countForTheStationKey += 10;


            latitude = r.NextDouble() * (2.3) + 31;
            longitude = r.NextDouble() * (1.2) + 34.3;
            address = myAddress;

            //function to round to 6 digits after the decimal point
            latitude = Math.Round(latitude, 6);
            longitude = Math.Round(longitude, 6);

            busesPassingAtThisStation = new List<BusLine>();
        }

        public BusStation(int myBusStationKey, string myAddress) //constructor for new bus station
        {

            busStationKey = myBusStationKey;


            latitude = r.NextDouble() * (2.3) + 31;
            longitude = r.NextDouble() * (1.2) + 34.3;
            address = myAddress;

            //arrondir a 6 chiffres apres la virgule
            latitude = Math.Round(latitude, 6);
            longitude = Math.Round(longitude, 6);

            busesPassingAtThisStation = new List<BusLine>();
        }


        //properties fields
        public int GetBusStationKey
        {
            get { return busStationKey; }
            set { busStationKey = value; }
        }

        public double GetLatitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double GetLongitude
        {
            get { return longitude; }
            set { latitude = value; }
        }

        public List<BusLine> GetBusesPassingAtThisStation
        {
            get { return busesPassingAtThisStation; }
            set { busesPassingAtThisStation = value; }
        }


        //methods
        public void addThebusToTheStation(BusLine myBus)
        {
            busesPassingAtThisStation.Add(myBus);
        }

        public void printTheBusLine()
        {
            Console.Write("Bus Line(s) in this station: ");
            foreach (BusLine element in busesPassingAtThisStation)
                Console.Write("#" + element.GetBusLineNum + ", ");
            Console.WriteLine("\n");
        }

        public override string ToString()
        {
            string str = "Bus Station Code: " + busStationKey + " , " + latitude + "°N  " + longitude + "°E";
            return str.ToString();
        }

        /// <summary>
        /// function that receive a bus station and return a list of bus in common with the other bus station (this)
        /// </summary>
        /// <param name="s2"></param>
        /// <returns></returns>
        public List<BusLine> findBusesInCommon(BusStation s2)
        {
            List<BusLine> busesInCommon = new List<BusLine>();
            foreach (BusLine element in this.GetBusesPassingAtThisStation)
            {
                foreach (BusLine element2 in s2.GetBusesPassingAtThisStation)
                {
                    if (element.GetBusLineNum == element2.GetBusLineNum)
                        busesInCommon.Add(element);
                }

            }
            if (busesInCommon.Count == 0)
                Console.WriteLine("There is no route between its two stations, Sorry...");
            return busesInCommon;
        }

       



        public class DistanceAndTimeBetweenStation : IComparable
        {
            //fields
            public double distanceBetweenStation = 0;
            public double timeInSeconds;
            TimeSpan span;
            public List<BusStation> subRoute;
            BusLine bus;

            //properties fields
            public double GetTimeInSeconde
            {
                get { return timeInSeconds; }
                set { timeInSeconds = value; }
            }

            public BusStation this[int index]
            {
                get { return subRoute[index]; }
                set { subRoute[index] = value; }
            }

            public double GetDistanceBetweenStation
            {
                get { return distanceBetweenStation; }
                set { distanceBetweenStation = value; }
            }

           

            //constructors

            public DistanceAndTimeBetweenStation(List<BusStation> subRoute1, BusLine myBus)
            {

                subRoute = subRoute1;

                for (int i = 1; i < subRoute.Count; i++)
                {
                    distanceBetweenStation += GetDistanceFromLatLonInKm(subRoute[i - 1].GetLatitude, subRoute[i - 1].GetLongitude, subRoute[i].GetLatitude, subRoute[i].GetLongitude);
                }

                //the speed of a bus is about 120 km per hour
                timeInSeconds = (3600 * (distanceBetweenStation / 120));

                span = TimeSpan.FromSeconds(timeInSeconds);

                bus = myBus;
            }

            public int getTheBestBusNum()
            {
                return bus.GetBusLineNum;
            }
           
            public int CompareTo(object other)
            {
                DistanceAndTimeBetweenStation d = (DistanceAndTimeBetweenStation)other;
                return GetTimeInSeconde.CompareTo(d.GetTimeInSeconde);
            }

            public override string ToString()
            {
                string str =  "Distance: " + GetDistanceBetweenStation + ", " + "Time: " + span + "\n";
                return str.ToString();
                
            }

            public double GetDistanceFromLatLonInKm(double lat1, double lon1, double lat2, double lon2)
            {
                var R = 6371d; // Radius of the earth in km
                var dLat = Deg2Rad(lat2 - lat1);  // deg2rad below
                var dLon = Deg2Rad(lon2 - lon1);
                var a =
                  Math.Sin(dLat / 2d) * Math.Sin(dLat / 2d) +
                  Math.Cos(Deg2Rad(lat1)) * Math.Cos(Deg2Rad(lat2)) *
                  Math.Sin(dLon / 2d) * Math.Sin(dLon / 2d);
                var c = 2d * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1d - a));
                var d = R * c; // Distance in km
                return d;


            }

            double Deg2Rad(double deg)
            {
                return deg * (Math.PI / 180d);
            }

           

        }
    }
}
