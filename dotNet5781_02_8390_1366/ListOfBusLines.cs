using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace dotNet5781_02_8390_1366
{
    public class ListOfBusLines:IEnumerable
    {
        private static List<BusLine> lstBusLines;

        public IEnumerator GetEnumerator()
        {
            return lstBusLines.GetEnumerator();
        }

        public ListOfBusLines()
        {
            lstBusLines = new List<BusLine>();
        }

        public void printAllBuses()
        {
            foreach (BusLine element in lstBusLines)
                Console.WriteLine(element.ToString());
        }

         public bool ExistBus(int myBusLineNum)
        {
            return lstBusLines.Exists(x => x.GetBusLineNum == myBusLineNum);
        }

        public bool ExistBus2(List<BusLine> lstBus, int myBusLineNum)
        {
            return lstBusLines.Exists(x => x.GetBusLineNum == myBusLineNum);
        }


        public void initialyseStationInBus(ListOfBusStation myBusStationLst)
        {
            BusLine bus;

            for (int i = 0; i < lstBusLines.Count; i++)
            {
                bus = lstBusLines[i];

            }
        }




        public void addBusLineToTheList(BusLine myBusLine)
        {
           lstBusLines.Add(myBusLine);       
        }

        public BusLine findABusInTheList(int myBusLineNum)
        {
            if (ExistBus(myBusLineNum))
                return lstBusLines.Find(x => x.GetBusLineNum == myBusLineNum);
            else
                return null;
        }


        public void deleteBusToTheTrip(int numBus)
        {
            if (ExistBus2(lstBusLines, numBus))
                lstBusLines.Remove(lstBusLines.Find(x => x.GetBusLineNum == numBus));
            else
                Console.WriteLine("This Bus Station Number doesn't exist in the system");

        }
    }
}


