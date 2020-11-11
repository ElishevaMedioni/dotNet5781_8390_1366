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


        public void initialyseStationInBus(ListOfBusStation myBusStationLst)
        {
            BusLine bus;

            for (int i = 0; i < lstBusLines.Count; i++)
            {
                bus = lstBusLines[i];

            }
        }



        //public int searchAStationInTheList(int stationNum)
        //{
        //    foreach (BusLine element in lstBusLines)
        //        if (element.searchStationInATrip(stationNum))
        //            return searchAStationInTheList(stationNum) ;
        //   // return element.GetBusLineNum;
        //}


        // public bool ExistBus(List<BusLine> myBusLineLst, BusLine myBusLine)
        //{
        //    bool flag = true;
        //    foreach (BusLine element in myBusLineLst)
        //    {
        //        if (myBusLine == element) 
        //            flag = false;
    
        //    }
        //    return flag;
        //}

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
       

        //public void deleteBusLineFromTheList(int myBusLineNum)
        //{
        //    if (ExistBus(lstBusLines, myBusLineNum))
        //        lstBusLines.Remove(lstBusLines.Find(x => x.GetBusLineNum == myBusStationKey));
        //    else
        //        Console.WriteLine("This Bus Station Number doesn't exist in the system");
        //    BusLine busLineToDelete;
        //    busLineToDelete = lstBusLines.Find(x => x.BusLineNum == myBusLineNum);
        //    lstBusLines.Remove(busLineToDelete);
        //}

    }
}
