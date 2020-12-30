﻿using System;
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
    

            DO.Line lin = DataSource.ListLines.Find(p => p.Id== id);

            if(lin!=null)
            {
                DataSource.ListLines.Remove(lin);
            }
            else
                throw new DO.BadStationException(id, $"bad Line id: {id}");

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
                throw new DO.BadPersonIdException(line.Id $"bad student id: {student.ID}");
        }

        //public void UpdateStudent(DO.Student student)
        //{
        //    DO.Student stu = DataSource.ListStudents.Find(p => p.ID == student.ID);
        //    if (stu != null)
        //    {
        //        DataSource.ListStudents.Remove(stu);
        //        DataSource.ListStudents.Add(stu.Clone());
        //    }
        //    else
        //        throw new DO.BadPersonIdException(student.ID, $"bad student id: {student.ID}");
        //}


        #endregion


        #region LineStation
        

        public DO.LineStation GetLineStation(int lineId, int station)
        {
            DO.LineStation linesta = DataSource.ListLineStations.Find(p => (p.LineId == lineId) && (p.Station == station));
            if (linesta != null)
                return linesta.Clone();
            else
                throw new DO.BadLineStationException(lineId, $"this station: {station} isn't in this line: {lineId}");
        }



        public void AddLineStation(DO.LineStation lineStation)
        {
            if (DataSource.ListLineStations.Exists(s => (s.LineId == lineStation.LineId && s.Station == lineStation.Station)))
                throw new DO.BadLineStationException(lineStation.Station, "This station is already in the system");

            DataSource.ListLineStations.Add(lineStation.Clone());
        }

        public void UpdateLineStation(DO.LineStation lineStation)
        {

        }

        public void DeleteLineStation(int lineId)
        {

        }

        #endregion


        #region AdjacentStations

        public DO.AdjacentStations GetAdjacentStations(int station1, int station2)
        {
            DO.AdjacentStations myAdjacentStations = DataSource.ListAdjacentStations.Find(p => p.Station1 == station1 && p.Station2 == station2);
           
            if (myAdjacentStations != null)
                return myAdjacentStations.Clone();
            else {  return null; }
            //    throw new DO.BadStationException(lineId, $"bad station code: {lineId}");

            
        }
        void AddAdjacentStations(DO.AdjacentStations lineStation)
        {
            int newAdjacentStation = DataSource.LineID++;

            DO.Line newLine = new DO.Line();
            newLine.Id = newAdjacentStation;

            DataSource.ListLines.Add(newLine.Clone());

        }
        void UpdateAdjacentStations(DO.AdjacentStations lineStation)
        {


        }
        void DeleteAdjacentStations(int lineId)
        {


        }
        #endregion

    }
}
