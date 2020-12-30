using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DLAPI
{
    public interface IDAL
    {
        #region Station
        IEnumerable<DO.Station> GetAllStations();
        DO.Station GetStation(int code);
        void AddStation(DO.Station station);
        void UpdateStation(DO.Station station);
        //void UpdateStation(int code, Action<DO.Station> update); //method that knows to updt specific fields in Person
        void DeleteStation(int code);

        #endregion


        #region Line
        DO.Line GetLine(int id);
        IEnumerable<DO.Line> GetAllLines();
       
        void AddLine(DO.Line line);
        void UpdateLine(DO.Line line);
        //void UpdateLine(int id, Action<DO.Line> update); //method that knows to updt specific fields in Line
        void DeleteLine(int id);
        #endregion

        #region LineStation
        
        DO.LineStation GetLineStation(int lineId, int station);
        void AddLineStation(DO.LineStation lineStation);
        void UpdateLineStation(DO.LineStation lineStation);
        void DeleteLineStation(int lineId);

        #endregion

        #region AdjacentStations

        DO.AdjacentStations GetAdjacentStations(int station1,int station2);
        void AddAdjacentStations(DO.AdjacentStations lineStation);
        void UpdateAdjacentStations(DO.AdjacentStations lineStation);
        void DeleteAdjacentStations(int lineId);


        #endregion



    }
}
