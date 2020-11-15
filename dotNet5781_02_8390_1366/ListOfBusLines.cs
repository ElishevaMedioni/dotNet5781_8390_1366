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
        //fields
        private static List<BusLine> lstBusLines;


        //properties fields
        public IEnumerator GetEnumerator()
        {
            return lstBusLines.GetEnumerator();
        }

        //constructor
        public ListOfBusLines()
        {
            lstBusLines = new List<BusLine>();
        }


        //methods
        public void printAllBuses()
        {
            foreach (BusLine element in lstBusLines)
                Console.WriteLine(element.ToString());
        }

         public bool ExistBus(int myBusLineNum)
        {
            return lstBusLines.Exists(x => x.GetBusLineNum == myBusLineNum);
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
 

        public void FindAndDelete(int myBusLineNum)
        {
            lstBusLines.Remove(lstBusLines.Find(x => x.GetBusLineNum == myBusLineNum));

        }



    }
}


