using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DO;

namespace DLAPI
{
    public interface IDL
    {
        #region Station
        IEnumerable<DO.Station> GetAllStations();
        DO.Station GetStation(int code);
        void AddStation(DO.Station station);
        void UpdateStation(DO.Station station);
        
        void DeleteStation(int code);

        #endregion


        #region Line
        DO.Line GetLine(int id);
        IEnumerable<DO.Line> GetAllLines();

        int AddLine(DO.Line line);
        void UpdateLine(DO.Line line);
        
        void DeleteLine(int id);
        



        #endregion

        #region LineStation

        DO.LineStation GetLineStation(int lineId, int station);
        IEnumerable<DO.LineStation> GetAllLineStations();
        void AddLineStation(DO.LineStation lineStation);
        void UpdateLineStation(DO.LineStation lineStation);
        DO.LineStation UpdateLineStation2(DO.LineStation lineStation);
        void DeleteLineStation(int lineId, int station);
        void DeleteStationToAllLines(int station);
        IEnumerable<DO.LineStation> GetLineStationInLineStationsList(Predicate<DO.LineStation> predicate);
       
        #endregion

        #region AdjacentStations

        //DO.AdjacentStations GetAdjacentStations(int Station1, int Station2);
        //void AddAdjacentStations(DO.AdjacentStations Adj, int station1, int station2);
        //void AddAdjacentStations(DO.AdjacentStations adj);
        //void UpdateAdjacentStations(int station1, int station2, DO.AdjacentStations adj);
        //void DeleteAdjacentStations(int station1, int station2, DO.AdjacentStations adj);


        #endregion

        #region LineTrip
        //DO.LineTrip GetLineTrip(int id);
        //void AddLineTrip(DO.LineTrip lineTrip);
        //void UpdateLineTrip(DO.LineTrip lineTrip);
        //void DeleteLineTrip(DO.LineTrip lineTrip);
        #endregion

        #region Bus


        IEnumerable<DO.Bus> GetAllBuses();
        DO.Bus GetBus(int license);

        void UpdateBus(DO.Bus buses);


        #endregion

    }
}
