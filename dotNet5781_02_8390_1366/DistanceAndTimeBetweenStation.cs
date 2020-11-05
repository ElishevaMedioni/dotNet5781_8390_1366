using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace dotNet5781_02_8390_1366
{
    class DistanceAndTimeBetweenStation : BusStation
    {
        
        private double distanceBetweenStation;
        private TimeSpan timeToTravel;

        

        DistanceAndTimeBetweenStation (DistanceAndTimeBetweenStation myBusStation)
        {
            var sCoord = new GeoCoordinate(latitude,longitude);
            var eCoord = new GeoCoordinate(myBusStation.latitude,myBusStation.longitude);

            var distanceBetweenStation = sCoord.GetDistanceTo(eCoord);
            

            //the speed of a bus is about 60 km per hour
            double time = 60 / distanceBetweenStation;
            timeToTravel = TimeSpan.FromHours(time);

        }


    }
}
