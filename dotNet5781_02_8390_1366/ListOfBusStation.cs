using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_8390_1366
{
    class ListOfBusStation
    {
        private List<BusStation> lstBusStation;

        public override string ToString()
        {
            return base.ToString(); 
        }

        public void addBusStationToTheList(BusStation myBusStation)
        {
            lstBusStation.Add(myBusStation);
        }

        public void deleteBusStationFromTheList(int myBusStationKey)
        {
            BusStation stationToDelete;
            stationToDelete = lstBusStation.Find(x => x.BusStationKey == myBusStationKey);
            lstBusStation.Remove(stationToDelete);
        }
    }
}
