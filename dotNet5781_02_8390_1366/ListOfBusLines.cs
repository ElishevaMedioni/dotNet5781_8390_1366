using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_8390_1366
{
    class ListOfBusLines
    {
        private List<BusLine> lstBusLines;

        public override string ToString()
        {
            return base.ToString();
        }

        static public bool ExistBus(List<BusLine> myBusLineLst, int myBusLineNum)
        {
            return myBusLineLst.Exists(x => x.GetBusLineNum == myBusLineNum);
        }


        static public bool ExistBus(List<BusLine> myBusLineLst, BusLine myBusLine)
        {
            bool flag = true;
            foreach (BusLine element in myBusLineLst)
            {
                if (myBusLine == element) 
                    flag = false;
    
            }
            return flag;
        }

        public void addBusLineToTheList(BusLine myBusLine)
        {
            if (ExistBus(lstBusLines, myBusLine))
               lstBusLines.Add(myBusLine);
            else
                Console.WriteLine();
        }


       

        public void deleteBusLineFromTheList(int myBusLineNum)
        {
            if (ExistBus(lstBusLines, myBusLineNum))
                lstBusLines.Remove(lstBusLines.Find(x => x.GetBusLineNum == myBusStationKey));
            else
                Console.WriteLine("This Bus Station Number doesn't exist in the system");
            BusLine busLineToDelete;
            busLineToDelete = lstBusLines.Find(x => x.BusLineNum == myBusLineNum);
            lstBusLines.Remove(busLineToDelete);
        }

    }
}
