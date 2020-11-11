using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_8390_1366
{
    public class ListOfBusStation //: IEnumerable
    {
        private List<BusStation> lstBusStation;

        public ListOfBusStation()
        {
            lstBusStation = new List<BusStation>();
        }

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
            stationToDelete = lstBusStation.Find(x => x.GetBusStationKey == myBusStationKey);
            lstBusStation.Remove(stationToDelete);
        }


        public BusStation findAStationInTheList(int myStationNum)
        {
            if (ExistStation(myStationNum))
                return lstBusStation.Find(x => x.GetBusStationKey == myStationNum);
            else
                return null;
        }


        public bool ExistStation(int myStationNum)
        {
            return lstBusStation.Exists(x => x.GetBusStationKey == myStationNum);
        }

        

        public void printAll(ListOfBusLines lst)
        {
            foreach (BusStation element in lstBusStation)
            {
                Console.WriteLine(element.ToString() + "\n");
                Console.WriteLine();
                Console.WriteLine(lst.searchAStationInTheList(element.GetBusStationKey));

            }
        }


    } 
}
