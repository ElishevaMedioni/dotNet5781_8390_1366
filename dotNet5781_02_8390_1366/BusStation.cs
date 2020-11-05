using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotNet5781_02_8390_1366
{
    public class BusStation
    {
        protected int busStationKey;
        protected double latitude;
        protected double longitude;
        private string address;
        static int countForTheStationKey = 0;

        BusStation()
        {
            busStationKey = countForTheStationKey++;
            //faire un random pr latitude et longitude
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

    }
}
