using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLAPI;
using BLAPI;
using BO;
namespace BL
{
     class BLImp:IBL
    {
       IDL dl = DLFactory.GetDL();

        #region Station
        BO.Station StationDoBoAdapter(DO.Station stationDO)
        {
            BO.Station stationBO = new BO.Station();
            int code = stationDO.Code;
            try
            {
                stationDO = dl.GetStation(code);
            }
            catch (DO.BadStationException ex)
            {
                throw new BO.BadStationException("bad station code", ex);
            }
            stationBO.Code = stationDO.Code;
            stationBO.Name = stationDO.Name;
            stationBO.Longitude = stationDO.Longitude;
            stationBO.Latitude = stationDO.Latitude;

            stationBO.LinesPassingAtThisStation = from ls in dl.GetLineStationInLineStationsList(ls => ls.Station == code)
                                                  let line = dl.GetLine(ls.LineId)
                                                  select line.LineDOtoBO(ls);
            return stationBO;                            
        }

        
   
        public BO.Station GetStation(int code)
        {
            DO.Station stationDO;
            try
            {
                stationDO = dl.GetStation(code);
            }
            catch (DO.BadStationException ex)
            {
                //Console.WriteLine("didnt find the station");
                throw new BO.BadStationException("bad station code", ex);
            }
            //BO.Station test = StationDoBoAdapter(stationDO);
            return StationDoBoAdapter(stationDO);
            
            //return test;

        }

        public IEnumerable<BO.Station> GetAllStations()
        {
            return from item in dl.GetAllStations()
                   select StationDoBoAdapter(item);
        }

        public void AddStation(BO.Station stationBO)
        {
            DO.Station stationDO = new DO.Station();
            stationDO.Code = stationBO.Code;
            stationDO.Name = stationBO.Name;
            stationDO.Longitude = stationBO.Longitude;
            stationDO.Latitude = stationBO.Latitude;

            try
            {
                dl.AddStation(stationDO);
                Console.WriteLine("station added successfully");
            }
            catch (DO.BadStationException ex)
            {
                throw new BO.BadStationException("bad station code", ex);
            }
        }

        public void UpdateStation(int code, string name)
        {

            DO.Station stationDO = new DO.Station();
            stationDO.Code = code;
            stationDO.Name = name;
            //mettre la latitude + longitude ?

            try
            {
                dl.UpdateStation(stationDO);
                Console.WriteLine("station updated successfully");
            }
            catch (DO.BadStationException ex)
            {
                throw new BO.BadStationException("bad station code", ex);
            }
        
        }

        public void DeleteStation(int code)
        {
            try
            {
                dl.DeleteStation(code);
                dl.DeleteStationToAllLines(code);
                Console.WriteLine("station deleted successfully");

            }
            catch (DO.BadLineStationException ex)
            {
                throw new BO.BadLineStationException("bad station code", ex);
            }
            catch (DO.BadStationException ex)
            {
                throw new BO.BadStationException("bad station code", ex);
            }
            
        }

        public BO.Line GetLinePassingAtThisStation(BO.Station station, int lineCode)
        {

           BO.Line line = station.LinesPassingAtThisStation.ToList().Find(p => p.Code == lineCode);
            if (line != null)
            {
                Console.WriteLine("find the line");
                return line;
            }
            else
                throw new BO.LinesPassingAtThisStationException("this line isn't passing in this station", lineCode);
             
        }
        public IEnumerable<BO.Line> GetAllLinesPassingAtThisStation(BO.Station station)
        {
            return station.LinesPassingAtThisStation;
        }

        public void AddALinePassingAtThisStation(BO.Station station, BO.Line line)
        {
            //var newCo = station.LinesPassingAtThisStation.ToList();
            //newCo.Add(line);
            ////station
            //station.LinesPassingAtThisStation.Add(line);
            ////fonction a utiliser ds region line

        }

        public void DeleteALinePassingAtThisStation(BO.Station station, int lineCode)
        {
            //BO.Line line = GetLinePassingAtThisStation(station, lineCode);
            //station.LinesPassingAtThisStation.ToList().Remove(line);
            ////fonction a utiliser ds region line
        }

        #endregion






        #region Line

        public BO.Line AdaptLineToBoToDo(DO.Line LineDO)
        {
            BO.Line LineBO = new BO.Line();



            int id = LineDO.Id;
            try
            {
                LineDO = dl.GetLine(id);
            }
            catch (DO.BadLineIdException ex)
            {
                throw new BO.BadLineIdException(id, "Bad Line", ex);
            }

            LineBO.Id = LineDO.Id;
            LineBO.Code = LineDO.Code;
            LineBO.Area = (Areas)LineDO.Area;
            LineBO.FirstStation = LineDO.FirstStation;
            LineBO.LastStation = LineDO.LastStation;
            //LineBO.ListOfStationsInThisLine = from sic in dl.GetLine(sic => sic. = id)
            //                                  let course = dl.GetLine(sic.CourseId)
            //                                  select course.CopyToStudentCourse(sic);


            return LineBO;
        }
       
        
        
        public BO.Line GetLine(int id)
        {
            DO.Line lineDO;

            try
            {
                lineDO = dl.GetLine(id);
            }

            catch (DO.BadLineIdException excep)
            {
                throw new BO.BadLineIdException(id,"Line id does not exist", excep);
            }

            return AdaptLineToBoToDo(lineDO);

        }


        public IEnumerable<BO.Line> GetAllLine()
        {

            return from item in dl.GetAllLines()
                   select AdaptLineToBoToDo(item);


        }



        //IEnumerable<BO.Line> GetLineCodeList()
        //{
        //    return from item in dl.GetLineListWithSelectedFields((Func<DO.Line, object>)((line) =>
        //    {
        //        try { Thread.Sleep(1500); } catch (ThreadInterruptedException e) { }
        //        return new BO.ListedPerson() { ID = line.ID, Name = dl.GetPerson(stud.ID).Name };
        //    }))
        //           let student = item as BO.ListedPerson
        //           //orderby student.ID
        //           select line;



            //}

            //IEnumerable<BO.Line> GetAllLineBy(Predicate<BO.Line> predicate)
            //{


            //}

         public void UpdateLine(DO.Line line)
        {
            dl.UpdateLine(line);

        }



        public void AddLine(BO.Line line, int id)
        {
            DO.Line LineDO  =  new DO.;


            //BO.Line LineBO = new BO.Line();
            //LineBO = AdaptLineToBoToDo(line);
            try
            {

                dl.AddLine(line, id);
            }
            catch (DO.BadLineIdException excep)
            {
                throw new BO.BadLineIdException(id,"Line exist", excep);
            }

        }



        public void DeleteLine(int id)
        {
            try
            {
                dl.DeleteLine(id);
            }
            catch (DO.BadLineIdException ex)
            {
                throw new BO.BadLineIdException(id,"Line Not exist", ex);
            }



        }


        #endregion

    }

}
