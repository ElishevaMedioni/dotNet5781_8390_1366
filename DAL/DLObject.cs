using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLAPI;
//using DO;
using DS;


namespace DL
{
    sealed class DLObject : IDL
    {
        #region singelton

        static readonly DLObject instance = new DLObject();
        static DLObject() { }
        DLObject() { }
        public static DLObject Instance { get => instance; }
        #endregion

        #region Station
        public DO.Station GetStation(int code)
        {
            DO.Station sta = DataSource.ListStations.Find(p => p.Code == code);
            if (sta != null)
                return sta.Clone();
            else
                throw new DO.BadStationException(code, $"bad station code: {code}");

        }

        public void AddStation(DO.Station station)
        {
            if (DataSource.ListStations.Exists(s => s.Code == station.Code))
                throw new DO.BadStationException(station.Code, "This station is already in the system");

            DataSource.ListStations.Add(station.Clone());
        }

        public void DeleteStation(int code)
        {
            DO.Station sta = DataSource.ListStations.Find(p => p.Code == code);

            if (sta != null)
            {
                DataSource.ListStations.Remove(sta);
            }
            else
                throw new DO.BadStationException(code, $"bad station code: {code}");
        }

        public void UpdateStation(DO.Station station)
        {
            DO.Station sta = DataSource.ListStations.Find(p => p.Code == station.Code);

            if (sta != null)
            {
                DataSource.ListStations.Remove(sta);
                DataSource.ListStations.Add(sta.Clone());
            }
            else
                throw new DO.BadStationException(station.Code, $"bad station code: {station.Code}");
        }

        public IEnumerable<DO.Station> GetAllStations()
        {
            return from station in DataSource.ListStations
                   select station.Clone();
        }

       

        #endregion

        #region Line
        public DO.Line GetLine(int id) //with the id of the line
        {
            DO.Line myLine = DataSource.ListLines.Find(p => p.Id == id);
            if (myLine != null)
                return myLine.Clone();
            else
                throw new DO.BadLineIdException(id, $"bad station code: {id}");

        }


        public void AddLine(DO.Line line, int id)
        {
            if (DataSource.ListLines.FirstOrDefault(p => p.Id == id) != null)
            {
                throw new DO.BadLineIdException(line.Id, "Duplicate Adjacent Stations");
            }
            else if (DataSource.ListLines.FirstOrDefault(p => p.Id == id) == null)
            {
                throw new DO.BadLineIdException(line.Id, "Missing");
            }

            int newId = DataSource.LineID++;

            DO.Line newLine = new DO.Line();
            newLine.Id = newId;

            DataSource.ListLines.Add(newLine.Clone());
        }







        public IEnumerable<DO.Line> GetAllLines()
        {
            return from line in DataSource.ListLines
                   select line.Clone();
        }

        public void DeleteLine(int id)
        {


            DO.Line lin = DataSource.ListLines.Find(p => p.Id == id);

            if (lin != null)
            {
                DataSource.ListLines.Remove(lin);
            }
            else
                throw new DO.BadLineIdException(id, $"bad Line id: {id}");

        }

        public void UpdateLine(DO.Line line)
        {
            DO.Line liine = DataSource.ListLines.Find(p => p.Id == line.Id);
            if (liine != null)
            {
                DataSource.ListLines.Remove(liine);
                DataSource.ListLines.Add(liine.Clone());
            }
            else
            { throw new DO.BadLineIdException(line.Id, $"bad line id: {liine.Id}"); }

        }




        #endregion


        #region LineStation


        public DO.LineStation GetLineStation(int lineId, int station)
        {
            DO.LineStation linesta = DataSource.ListLineStations.Find(p => (p.LineId == lineId) && (p.Station == station));
            if (linesta != null)
                return linesta.Clone();
            else
                throw new DO.BadLineStationException(lineId, $"this station: {station} isn't in this line: {lineId} or bad line station");
        }

        public IEnumerable<DO.LineStation> GetAllLineStations()
        {
            return from lineStation in DataSource.ListLineStations
                   select lineStation.Clone();
        }

        public void AddLineStation(DO.LineStation lineStation)
        {
            if (DataSource.ListLineStations.Exists(s => (s.LineId == lineStation.LineId && s.Station == lineStation.Station)))
                throw new DO.BadLineStationException(lineStation.Station, "This station is already in the system");

            DataSource.ListLineStations.Add(lineStation.Clone());
        }

        public void UpdateLineStation(DO.LineStation lineStation)
        {
            DO.LineStation lineSta = DataSource.ListLineStations.Find(s => (s.LineId == lineStation.LineId && s.Station == lineStation.Station));

            if (lineSta != null)
            {
                DataSource.ListLineStations.Remove(lineSta);
                DataSource.ListLineStations.Add(lineSta.Clone());
            }
            else
                throw new DO.BadLineStationException(lineStation.Station, lineStation.LineId, $"bad line station");
        }

        public void DeleteLineStation(int lineId, int station)
        {
            DO.LineStation lineSta = DataSource.ListLineStations.Find(p => (p.LineId == lineId) && (p.Station == station));

            if (lineSta != null)
            {
                DataSource.ListLineStations.Remove(lineSta);
            }
            else
                throw new DO.BadLineStationException(lineId, $"this station: {station} isn't in this line: {lineId} or bad line station");
        }

        public IEnumerable<DO.LineStation> GetLineStationInLineStationsList(Predicate<DO.LineStation> predicate)
        {
            return from ls in DataSource.ListLineStations
                   where predicate(ls)
                   select ls.Clone();
           
        }

        public void DeleteStationToAllLines(int station)
        {
            DataSource.ListLineStations.RemoveAll(p => p.Station == station);
        }

        #endregion


        #region AdjacentStations
           public DO.AdjacentStations GetAdjacentStations(int Station1, int Station2)
        {
            DO.AdjacentStations Adj = DataSource.ListAdjacentStations.Find(p => p.Station1 == Station1 && p.Station2 == Station2);

            if (Adj != null)
            {
                return Adj.Clone();
            }

            else
            {

                throw new DO.BadAdjacentStationsException(Adj.Station1, Adj.Station2, $"bad stations: {Station1},{Station2}");
            }

        }
        public void AddAdjacentStations(DO.AdjacentStations Adj, int station1, int station2)
        {
            if (DataSource.ListAdjacentStations.FirstOrDefault(p => p.Station1 == station1 && p.Station2 == station2) != null)
            {
                throw new DO.BadAdjacentStationsException(Adj.Station1, Adj.Station2, "Duplicate Adjacent Stations");
            }


            else if (DataSource.ListAdjacentStations.FirstOrDefault(p => p.Station1 == station1 && p.Station2 == station2) == null)
            {
                throw new DO.BadAdjacentStationsException(Adj.Station1, Adj.Station2, "Missing");
            }


            else
            {
                DataSource.ListAdjacentStations.Add(Adj.Clone());
            }

        }



        public void UpdateAdjacentStations(int station1, int station2, DO.AdjacentStations adj)
        {
            DO.AdjacentStations myAdjacentStations = DataSource.ListAdjacentStations.Find(p => p.Station1 == station1 && p.Station2 == station2);

            if (myAdjacentStations != null)
            {
                DataSource.ListAdjacentStations.Remove(adj);
                DataSource.ListAdjacentStations.Add(adj.Clone());
            }

            else
            {
                throw new DO.BadAdjacentStationsException(adj.Station1, adj.Station2, $"bad thing");
            }


        }



        public void DeleteAdjacentStations(int station1, int station2, DO.AdjacentStations adj)
        {
            DO.AdjacentStations myAdjacentStations = DataSource.ListAdjacentStations.Find(p => p.Station1 == station1 && p.Station2 == station2);

            if (myAdjacentStations != null)
            {
                DataSource.ListAdjacentStations.Remove(adj);

            }
            else
            {

                throw new DO.BadAdjacentStationsException(adj.Station1, adj.Station2, $"these station: {station1},{station2} isn't adjacent");
            }

        }

        #endregion

    }
}
