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
    }
}
