using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BLAPI
{
    public interface IBL
    {
        #region Station
        BO.Station GetStation(int code);
        IEnumerable<BO.Station> GetAllStations();
        void AddStation(BO.Station station);
        void UpdateStation(int code, string name);
        void DeleteStation(int code);
        BO.Line GetLinePassingAtThisStation(BO.Station station, int lineCode);
        void AddALinePassingAtThisStation(BO.Station station, BO.Line line);
        IEnumerable<BO.Line> GetAllLinesPassingAtThisStation(BO.Station station);
        void DeleteALinePassingAtThisStation(BO.Station station, int id);

        #endregion

        #region Line
        BO.Line GetLine(int id);
        IEnumerable<BO.Line> GetAllLine();
        //IEnumerable<BO.Line> GetLineIDList();

        //IEnumerable<BO.Line> GetAllLineBy(Predicate<BO.Line> predicate);

       // void UpdateLine(BO.Line line);  // Update Line 
        //void AddLine(DO.Line line, int id);  // Update Line 
        void DeleteLine(int id); // delete Line



        #endregion
    }
}
