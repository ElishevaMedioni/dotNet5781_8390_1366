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
            lineResult.Id = ls.LineId;
            lineResult.Code = ls.Station;
            lineResult.Area = (BO.Areas)line.Area;
            return lineResult;

        }

        public static BO.Line LineDOtoBO2(this DO.Line line, DO.Line line2)
        {
            BO.Line lineRes = new BO.Line();
            lineRes.Id =line2.Id;
            lineRes.Area = (BO.Areas)line2.Area;
            lineRes.Code = line2.Code;
            lineRes.FirstStation = line2.FirstStation;
            lineRes.LastStation = line2.LastStation;
            return lineRes;

        }








    }
}
