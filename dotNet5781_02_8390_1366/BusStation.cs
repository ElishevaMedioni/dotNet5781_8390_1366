using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Device.Location;


namespace dotNet5781_02_8390_1366
{
    public class BusStation
    {
        protected int busStationKey;
        protected double latitude;
        protected double longitude;
        private string address;
        static int countForTheStationKey = 100000;

        BusStation()
        {
            busStationKey = countForTheStationKey += 10;
            Calculate(31, 34.3, 33.3, 35.5);

        }

        BusStation(string myAddress)
        {

            address = myAddress;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public int BusStationKey
        {
            get { return busStationKey; }
            set { busStationKey = value; }
        }

        public class Coordinate    //sous classes pour trouver latitude longitude
        {
            public double Latitude { set; get; }
            public double Longitude { set; get; }
        }


        public static Coordinate Calculate(double location1, double location2, double location3,
        double location4)
        {

            double minLat = location1;
            double minLon = location2;
            double maxLat = location3;
            double maxLon = location4;

            Random r = new Random();
            Coordinate point = new Coordinate();
            //           Calculate(31, 34.3, 33.3, 35.5);
            point.Latitude = r.NextDouble() * (maxLat - minLat) + minLat;
            point.Longitude = r.NextDouble() * (maxLon - minLon) + minLon;

            return point;
        }



        public class DistanceAndTimeBetweenStation : BusStation
        {

            public double distanceBetweenStation;
            public TimeSpan timeToTravel;

            // public static DistanceAndTimeBetweenStation() { }
            DistanceAndTimeBetweenStation(DistanceAndTimeBetweenStation myBusStation) : base()

            {
                var sCoord = new GeoCoordinate(latitude, longitude);
                var eCoord = new GeoCoordinate(myBusStation.latitude, myBusStation.longitude);

                var distanceBetweenStation = sCoord.GetDistanceTo(eCoord);


                //the speed of a bus is about 60 km per hour
                double time = 60 / distanceBetweenStation;
                timeToTravel = TimeSpan.FromHours(time);

            }


        }
    }
}
