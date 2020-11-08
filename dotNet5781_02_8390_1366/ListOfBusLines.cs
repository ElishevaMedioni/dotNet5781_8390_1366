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

        public void addBusLineToTheList(BusLine myBusLine)
        {
            lstBusLines.Add(myBusLine);
        }

        public void deleteBusLineFromTheList(int myBusLineNum)
        {
            BusLine busLineToDelete;
            busLineToDelete = lstBusLines.Find(x => x.BusLineNum == myBusLineNum);
            lstBusLines.Remove(busLineToDelete);
        }

    }
}
