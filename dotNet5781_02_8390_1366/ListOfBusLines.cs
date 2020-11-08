using System;
using System.Collections.Generic;
using System.Linq;
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

        static public bool ExistBus(int myBusLineNum)
        {
            return lstBusLines.Exists(x => x.GetBusLineNum == myBusLineNum);
        }

        public void addBusLineToTheList(BusLine myBusLine, int myBusLineNum)
        {
            if (ExistBus())
            lstBusLines.Add(myBusLine);
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
