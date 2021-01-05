using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLAPI;


namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BO.Station station = new BO.Station();
            station.Code = 3;
            station.Longitude = 4.2;
            station.Latitude = 3.4;
            station.Name = "bye";

            IBL bl = BLFactory.GetBL("1");
            

            bl.AddStation(station);
            
            Console.WriteLine("HELLO");
            Console.ReadKey();
        }
    }
}
