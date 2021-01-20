using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    static class DeepCopy
    {
        public static BO.Line LineDOtoBO(this DO.Line line, DO.LineStation ls)
        {
            BO.Line lineResult= new BO.Line();
            lineResult.Id = line.Id;  
            lineResult.Code = line.Code;
            lineResult.Area = (BO.Areas)line.Area;
            lineResult.FirstStation = line.FirstStation;
            lineResult.LastStation = line.LastStation;
            return lineResult;

        }



        public static BO.Station LineDOtoBO2(this DO.Station station, DO.LineStation ls)
        {
            BO.Station stationn = new BO.Station();
            stationn.Code = station.Code;
            stationn.Latitude = station.Latitude;
            stationn.Longitude = station.Longitude;
            stationn.Name = station.Name;


            return stationn;

        }











    }
}
