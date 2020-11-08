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
        protected int busStationKey;
        protected double latitude;
        protected double longitude;
        private string address;
        static int countForTheStationKey = 100000;

        BusStation(){}

        BusStation(string myAddress)
        {

            busStationKey = countForTheStationKey += 10;

            Random r = new Random();
            latitude = r.NextDouble() * (2.3) + 31;
            longitude = r.NextDouble() * (1.2) + 34.3;
            address = myAddress;
        }



        public override string ToString()
        {
            return base.ToString();
        }

        public int GetBusStationKey
        {
            get { return busStationKey; }
            set { busStationKey = value; }
        }


        public class DistanceAndTimeBetweenStation
        {
            public string str;
            public double distanceBetweenStation;
            public TimeSpan timeToTravel;

            // public static DistanceAndTimeBetweenStation() { }



           // DistanceAndTimeBetweenStation() { };
            

            DistanceAndTimeBetweenStation(BusStation myBusStation, BusStation myBusStation2)

            {
                var sCoord = new GeoCoordinate(myBusStation2.latitude, myBusStation2.longitude);
                var eCoord = new GeoCoordinate(myBusStation.latitude, myBusStation.longitude);
                var distanceBetweenStation = sCoord.GetDistanceTo(eCoord);


                //the speed of a bus is about 60 km per hour
                double time = 60 / distanceBetweenStation;
                timeToTravel = TimeSpan.FromHours(time);

            }

        }
    }
}
