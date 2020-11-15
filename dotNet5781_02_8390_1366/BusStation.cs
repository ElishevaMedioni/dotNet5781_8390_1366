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
        private int busStationKey;
        protected double latitude;
        protected double longitude;
        protected string address;
        static int countForTheStationKey = 100000;
        static Random r = new Random();
        public List<BusLine> busesPassingAtThisStation;

        BusStation() { }

        public BusStation(string myAddress)
        {

            busStationKey = countForTheStationKey += 10;


            latitude = r.NextDouble() * (2.3) + 31;
            longitude = r.NextDouble() * (1.2) + 34.3;
            address = myAddress;

            //arrondir a 6 chiffres apres la virgule
            latitude = Math.Round(latitude, 6);
            longitude = Math.Round(longitude, 6);

            busesPassingAtThisStation = new List<BusLine>();
        }

        public BusStation(int myBusStationKey, string myAddress)
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

        public void printTheBusLine()
        {
            Console.Write("Bus Line(s) in this station: ");
            foreach (BusLine element in busesPassingAtThisStation)
                Console.Write("#" + element.GetBusLineNum + ", ");
            Console.WriteLine("\n");
        }

        public override string ToString()
        {
            string str = "Bus Station Code: " + busStationKey + "  ," + latitude + "°N  " + longitude + "°E";
            return str.ToString();
        }

        public int GetBusStationKey
        {
            get { return busStationKey; }
            set { busStationKey = value; }
        }

        public double GetLatitude
        {
            get { return latitude; }
            set { latitude = value; }
        }//

        public double GetLongitude
        {
            get { return longitude; }
            set { latitude = value; }
        }//

        public List<BusLine> GetBusesPassingAtThisStation
        {
            get { return busesPassingAtThisStation; }
            set { busesPassingAtThisStation = value; }
        }
        public void addThebusToTheStation(BusLine myBus)
        {
            busesPassingAtThisStation.Add(myBus);
        }

        //public bool ExistBusInThisStation(int myBusLine)
        //{

        //    return searchStationInATrip(myBusLine); //regler ce pb
        //}

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
            return busesInCommon;
        }

       


       

        // public void 

        public class DistanceAndTimeBetweenStation : IComparable
        {
            public string str;
            static public double distanceBetweenStation = 0;
            public TimeSpan timeToTravel;
            public List<BusStation> subRoute;
            // public static DistanceAndTimeBetweenStation() { }

            public BusStation this[int index]
            {
                get { return subRoute[index]; }
                set { subRoute[index] = value; }
            }

            public int CompareTo(object other)
            {
                DistanceAndTimeBetweenStation d = (DistanceAndTimeBetweenStation)other;
                return distanceBetweenStation.CompareTo(d.GetDistanceBetweenStation);
            }

            public override string ToString()
            {
                string str = "Distance: " + GetDistanceBetweenStation + "  ," + "Time: " + timeToTravel + "\n";
                return str.ToString();
            }

            public double GetDistanceBetweenStation
            {
                get { return distanceBetweenStation; }
                set { distanceBetweenStation = value; }
            }
            double Deg2Rad(double deg)
            {
                return deg * (Math.PI / 180d);
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

            public DistanceAndTimeBetweenStation(List<BusStation> subRoute1)


            {
               

                subRoute = subRoute1;
             
              
                for (int i = 1; i < subRoute.Count; i++)
                {

                    distanceBetweenStation+=GetDistanceFromLatLonInKm(subRoute[i-1].GetLatitude, subRoute[i-1].GetLongitude, subRoute[i].GetLatitude, subRoute[i].GetLongitude);
                    

                }

                //the speed of a bus is about 60 km per hour
                double time = 60 / distanceBetweenStation;
                //timeToTravel = TimeSpan.FromHours(time);

            }

            public void print()
            {
                Console.WriteLine(distanceBetweenStation.ToString()); 
            }





        }
    }
}
