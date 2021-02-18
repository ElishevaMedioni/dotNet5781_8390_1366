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
        void UpdateStation(BO.Station stationBO);
        void DeleteStation(int code);
        BO.Line GetLinePassingAtThisStation(BO.Station station, int lineCode);
        
        IEnumerable<BO.Line> GetAllLinesPassingAtThisStation(BO.Station station);
        

        #endregion

        #region Line
        BO.Line GetLine(int id);
        IEnumerable<BO.Line> GetAllLine();
        int AddLine(BO.Line lineBO);
        void UpdateLine(BO.Line line);
        
        IEnumerable<BO.Station> GetAllStationsInThisLine(BO.Line line);

        void AddFirstAndLastStation(BO.Line line, BO.Station firstS, BO.Station lastS);

        void UpdateFirstStation(BO.Line line, BO.Station firstS);
        void UpdateLastStation(BO.Line line, BO.Station lastS);
        void DeleteLine(BO.Line lineToDel); 

        
        IEnumerable<BO.Line> ReturnTheLineByArea(BO.Areas area);
        IEnumerable<IGrouping<BO.Areas, BO.Line>> GroupingFunction();
        #endregion

        #region LineStation
        void AddAStationInALine(BO.Station stationToAdd, BO.Line line, BO.Station stationPrev);
         void DeleteStationInALine(int code, BO.Line line);
        void DeleteStationInAllTheLines(int code);

        #endregion

        #region AdjacentStations

        double GetDistanceFromLatLonInKm(double lat1, double lon1, double lat2, double lon2);
        double Deg2Rad(double deg);
        
       // double DistanceBetweenAdjacentStation(DO.Station station1, DO.Station station2);
        double DistanceBetweenAdjacentStation(BO.Station station1, BO.Station station2);
        List<double> GetDistanceStationList(IEnumerable<BO.Station> stationList);
        List<TimeSpan> GetTimeStationList(List<double> distance_stationList);

        TimeSpan TimeBetweenAdjacentStation(double distance);



        #endregion

       

        #region Bus
        IEnumerable<BO.Bus> GetAllBus();
        BO.Bus AdaptBusToBoToDo(DO.Bus BusDO);
        BO.Bus GetBus(int license);


        IEnumerable<BO.Bus> GetAllBuses(BO.Bus bus);


        void UpdateBus(BO.Bus bus);


        #endregion
    }
}
