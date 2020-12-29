using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLAPI;
using DO;
using DS;


namespace DAL
{
    sealed class DLObject:IDAL
    {
        #region singelton

        static readonly DLObject instance = new DLObject();
        static DLObject() {  }
        DLObject() { }
        public static DLObject Instance { get=> instance; }
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
                throw new DO.BadStationException(code, $"bad student id: {code}");
        }

        public void UpdateStation(DO.Station station)
        {

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
                throw new DO.BadStationException(id, $"bad station code: {id}");

        }


        public void AddLine(DO.Line line)
        {
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

        }

        public void UpdateLine(DO.Line line)
        {

        }



        #endregion

    }
}
