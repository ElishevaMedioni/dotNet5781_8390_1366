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
    class BLImp : IBL
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
                
                throw new BO.BadStationException("bad station code", ex);
            }
            
            return StationDoBoAdapter(stationDO);


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

        public void UpdateStation(BO.Station stationBO)
        {

            DO.Station stationDO = new DO.Station
            {
                Code = stationBO.Code,
                Name = stationBO.Name,
                Latitude = stationBO.Latitude,
                Longitude = stationBO.Longitude
            };
            

            try
            {
                dl.UpdateStation(stationDO);
               
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

                return line;
            }
            else
                throw new BO.LinesPassingAtThisStationException("this line isn't passing in this station", lineCode);

        }
        public IEnumerable<BO.Line> GetAllLinesPassingAtThisStation(BO.Station station)
        {
            return station.LinesPassingAtThisStation;
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
                throw new BO.BadLineException("Bad Line", ex);
            }

            LineBO.Id = LineDO.Id;
            LineBO.Code = LineDO.Code;
            LineBO.Area = (Areas)LineDO.Area;
            LineBO.FirstStation = LineDO.FirstStation;
            LineBO.LastStation = LineDO.LastStation;

            LineBO.ListOfStationsInThisLine = from item in dl.GetLineStationInLineStationsList(item => item.LineId == id)
                                              let station = dl.GetStation(item.Station)
                                              select station.LineDOtoBO2(item);
            //a partir 
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
                throw new BO.BadLineException("Line id does not exist", excep);
            }

            return AdaptLineToBoToDo(lineDO);

        }


        public IEnumerable<BO.Line> GetAllLine()
        {
            return from item in dl.GetAllLines()
                   select AdaptLineToBoToDo(item);


        }

        

        public int AddLine(BO.Line lineBO)
        {
            DO.Line lineDO = new DO.Line();
            
            lineDO.Code = lineBO.Code;
            lineDO.Area = (DO.Areas)lineBO.Area;
            lineDO.FirstStation = lineBO.FirstStation;
            lineDO.LastStation = lineBO.LastStation;

            int id;
            try
            {

              id =  dl.AddLine(lineDO);
                return id;

            }
            catch (DO.BadLineIdException excep)
            {
                throw new BO.BadLineException("Line exist");
            }

        }



        public void DeleteLine(BO.Line lineToDel)
        {
            IEnumerable<DO.LineStation> lineStations = from item in dl.GetLineStationInLineStationsList(p => p.LineId == lineToDel.Id )
                                                       select item;

            try { 
                foreach (DO.LineStation item in lineStations)
                {
                    dl.DeleteLineStation(lineToDel.Id, item.Station);
                }
            
                dl.DeleteLine(lineToDel.Id);
            }
            catch (DO.BadLineIdException ex)
            {
                throw new BO.BadLineException("Line Not exist", ex);
            }



        }

        public void UpdateLine(BO.Line line)
        {
            DO.Line lineDO = new DO.Line
            {
                Id = line.Id,
                Code = line.Code,
                Area = (DO.Areas) line.Area,
                FirstStation = line.FirstStation,
                LastStation = line.LastStation,
            };

            try
            {
                dl.UpdateLine(lineDO);
            }
            catch (DO.BadLineCodeException ex)
            {
                throw new BO.BadStationException("error to update the line", ex);
            }
            

        }

      

        public IEnumerable<BO.Station> GetAllStationsInThisLine(BO.Line line)
        {
            line.ListOfStationsInThisLine = from item in dl.GetLineStationInLineStationsList(item => item.LineId == line.Id)
                                              let station = dl.GetStation(item.Station)
                                              select station.LineDOtoBO2(item);
            return line.ListOfStationsInThisLine;
        }

        public void AddFirstAndLastStation(BO.Line line, BO.Station firstS, BO.Station lastS)
        {
            if (firstS == lastS)
            {
                throw new BO.BadStationException(firstS.Code, "ERROR, The first and the last station are the same!!");

            }

            DO.LineStation newLineStation = new DO.LineStation
            {
                LineId = line.Id,
                Station = firstS.Code,
                LineStationIndex = 0
            };
            dl.AddLineStation(newLineStation);

            DO.LineStation newLineStation2 = new DO.LineStation
            {
                LineId = line.Id,
                Station = lastS.Code,
                LineStationIndex = 1
            };
            dl.AddLineStation(newLineStation2);

            line.ListOfStationsInThisLine = GetAllStationsInThisLine(line);
        }


        public void UpdateFirstStation(BO.Line line, BO.Station firstS)
        {
            
            DO.LineStation lineStation1 = dl.GetAllLineStations().ToList().Find(p => p.Station == firstS.Code && p.LineId == line.Id);
            int indexLS1 = lineStation1.LineStationIndex;

            IEnumerable<DO.LineStation> lineStations = from item in dl.GetLineStationInLineStationsList(p => p.LineId == line.Id && p.LineStationIndex < indexLS1)
                                                       select dl.UpdateLineStation2(new DO.LineStation
                                                       {
                                                           LineId = item.LineId,
                                                           Station = item.Station,
                                                           LineStationIndex = item.LineStationIndex + 1
                                                       });



            DO.LineStation newFS = new DO.LineStation
            {
                LineId = line.Id,
                Station = firstS.Code,
                LineStationIndex = 0
            };

            
            dl.UpdateLineStation(newFS);

            line.ListOfStationsInThisLine = GetAllStationsInThisLine(line);
        }

        public void UpdateLastStation(BO.Line line, BO.Station lastS)
        {
            DO.LineStation lineStation1 = dl.GetAllLineStations().ToList().Find(p => p.Station == lastS.Code && p.LineId == line.Id);
            int indexLS1 = lineStation1.LineStationIndex;
            
            DO.LineStation lineStation2 = dl.GetAllLineStations().ToList().Find(p => p.Station == line.LastStation && p.LineId == line.Id);

            IEnumerable<DO.LineStation> lineStations = from item in dl.GetLineStationInLineStationsList(p => p.LineId == line.Id && p.LineStationIndex > indexLS1)
                                                       select dl.UpdateLineStation2(new DO.LineStation
                                                       {
                                                           LineId = item.LineId,
                                                           Station = item.Station,
                                                           LineStationIndex = item.LineStationIndex - 1
                                                       });

            DO.LineStation newLS = new DO.LineStation
            {
                LineId = line.Id,
                Station = lastS.Code,
                LineStationIndex = lineStation2.LineStationIndex
            };

            dl.UpdateLineStation(newLS);
            //line.ListOfStationsInThisLine = GetAllStationsInThisLine(line);
        }

        public IEnumerable<IGrouping<BO.Areas, BO.Line>> GroupingFunction()
        {
            List<BO.Line> lines = new List<BO.Line>();
            lines = GetAllLine().ToList();
            var linequery = from item in lines
                            group item by item.Area into g
                            select g;
            return linequery;
        }
      
        public IEnumerable<BO.Line> ReturnTheLineByArea(BO.Areas area)
        {
            IEnumerable<IGrouping<BO.Areas, BO.Line>> groupedData = GroupingFunction();
            foreach (var group in groupedData)
            {
                if (group.Key == area)
                    return group;
               

            }
            return null;
            //foreach (var group in groupedData)
            //{
            //    var groupKey = group.Key;
            //    foreach (var groupedItem in group)
            //        DoSomethingWith(groupKey, groupedItem);
            //}
        }
        #endregion


        #region LineStation
        public void AddAStationInALine(BO.Station stationToAdd, BO.Line line, BO.Station stationPrev)
        {
            //we check before if this station exist in the system
            if (!(GetAllStations().ToList().Exists(p => p.Code == stationToAdd.Code)))
                throw new BO.BadStationException("This station doesn't exist in the system", stationToAdd.Code);
              
            
                //we check if the station isn't already in this line
             if (GetAllStationsInThisLine(line).ToList().Exists(p => p.Code == stationToAdd.Code))
                 throw new BO.BadStationException(stationToAdd.Code, "this station is already in this line");




            //step 1 modify lineStationIndex
            DO.LineStation lineStation1 = dl.GetAllLineStations().ToList().Find(p => p.Station == stationPrev.Code && p.LineId == line.Id);
            int indexPrev = lineStation1.LineStationIndex;

            IEnumerable<DO.LineStation> lineStations = from item in dl.GetLineStationInLineStationsList(p => p.LineId == line.Id && p.LineStationIndex > indexPrev)
                                                               select dl.UpdateLineStation2(new DO.LineStation
                                                               {
                                                                   LineId = item.LineId,
                                                                   Station = item.Station,
                                                                   LineStationIndex = item.LineStationIndex+1 
                                                               });

                    //step 2 adding a new object line station with our new station
                    DO.LineStation newLineStation = new DO.LineStation
                    {
                        LineId = line.Id,
                        Station = stationToAdd.Code,
                        LineStationIndex = indexPrev 
                    };
                    dl.AddLineStation(newLineStation);

            line.ListOfStationsInThisLine = GetAllStationsInThisLine(line);

                   
            
        }

        public void DeleteStationInALine(int code, BO.Line line)
        {
            if (GetAllStations().ToList().Exists(p => p.Code == code))
            {
                if (GetAllStationsInThisLine(line).ToList().Exists(p => p.Code == code))
                {
                    DO.LineStation lineStationToDel = dl.GetAllLineStations().ToList().Find(p => p.LineId == line.Id && p.Station == code);
                    DO.Station stationToDel = dl.GetAllStations().ToList().Find(p => p.Code == code);

                    int index = lineStationToDel.LineStationIndex;

              
                    //step 1 modify lineStationIndex
                    IEnumerable<DO.LineStation> lineStations = from item in dl.GetLineStationInLineStationsList(p => p.LineId == line.Id && p.LineStationIndex > index)
                                                               select dl.UpdateLineStation2(new DO.LineStation
                                                               {
                                                                   LineId = item.LineId,
                                                                   Station = item.Station,
                                                                   LineStationIndex = item.LineStationIndex - 1
                                                               });

                    // step 2 delete LineStation
                    dl.DeleteLineStation(line.Id, code);
     

                }
                else
                {
                    throw new BO.StationsInThisLine("this station isn't in this line", code);
                }
            }
            else
            {
                throw new BO.BadStationException("This station doesn't exist in the system", code);
            }
        }

        public void DeleteStationInAllTheLines(int code)
        {
            BO.Station stationTODelete = GetStation(code);

            if (stationTODelete == null)
                throw new BO.BadStationException(code, "This station doesn't exists");
            
            IEnumerable<Line> linetoUpdate = GetAllLine().Where(x => x.ListOfStationsInThisLine.Any(y=> y.Code == stationTODelete.Code));
            
            foreach (BO.Line line in linetoUpdate)
                DeleteStationInALine(code,line);
            try
            {
                dl.DeleteStation(code);
            }
            catch (DO.BadStationException ex) 
            { throw new BO.BadStationException(code, "bad"); }        
        }

        #endregion


        #region AdjacentStations

        public double GetDistanceFromLatLonInKm(double lat1, double lon1, double lat2, double lon2)
        {
            var R = 6371d; // Radius of the earth in km
            var dLat = Deg2Rad(lat2 - lat1);  // deg2rad below
            var dLon = Deg2Rad(lon2 - lon1);
            var a =
              Math.Sin(dLat / 2d) * Math.Sin(dLat / 2d) +
              Math.Cos(Deg2Rad(lat1)) * Math.Cos(Deg2Rad(lat2)) *
              Math.Sin(dLon / 2d) * Math.Sin(dLon / 2d);
            var c = 2d * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1d - a));
            var d = R * c; // Distance in km

            d = Math.Round(d, 1);
            return d;


        }
        public List<double> GetDistanceStationList(IEnumerable<BO.Station> stationList) {
            List<BO.Station> myList = stationList.ToList();
            List<double> result = new List<double>();
            result.Add(0);
            int size = myList.Count();
            for(int i = 1; i < size; i++) 
            {
                result.Add(result[i - 1] + DistanceBetweenAdjacentStation(myList[i-1], myList[i]));

            }
            for (int i=1; i<size; i++)
            {
                result[i] = Math.Round(result[i], 2);
            }
            return result;


        }
        public List<TimeSpan> GetTimeStationList(List<double> distance_stationList)
        {
            List<TimeSpan> result = new List<TimeSpan>();


            int size = distance_stationList.Count();
            result.Add(new TimeSpan(0,0,0));
            for (int i = 1; i < size ; i++)
            {
                result.Add( TimeBetweenAdjacentStation(distance_stationList[i]));
            }
            return result;


        }
        public double Deg2Rad(double deg)
        {
            return deg * (Math.PI / 180d);
        }

       

        public double DistanceBetweenAdjacentStation(BO.Station station1, BO.Station station2)
        {
            return GetDistanceFromLatLonInKm(station1.Latitude, station1.Longitude, station2.Latitude, station2.Longitude);
        }

        public TimeSpan TimeBetweenAdjacentStation(double distance)
        {
            //the speed of a bus is about 60 km per hour
             double timeInSeconds = (3600 * (distance / 60));

            return TimeSpan.FromSeconds(timeInSeconds);
        }

        #endregion


        #region LineTiming 
        //public BO.LineTiming GetLineTiming(int id)
        //{

        //}
        //IEnumerable<BO.LineTiming> GetAllLineTiming();

        //void UpdateLineTiming(BO.LineTiming lineT);

        //void DeleteLineTiming(BO.LineTiming lineT);
        #endregion

        #region Bus
        public BO.Bus AdaptBusToBoToDo(DO.Bus BusDO) //PRIVATE
        {
            BO.Bus BusBO = new BO.Bus();



            int license = BusDO.License;


            try
            {
                BusDO = dl.GetBus(license);
            }
            catch (DO.BadBusException ex)
            {
                throw new BO.BadBusException("Bad Bus", ex);
            }

            BusBO.License = BusDO.License;
            BusBO.Status = (BO.BusStatus)BusDO.Status;
            BusBO.TotalTrip = BusDO.TotalTrip;
            BusBO.FromDate = BusDO.FromDate;
            BusBO.FuelRemain = BusDO.FuelRemain;


            return BusBO;

        }





        public DO.Bus convertDAO(DO.Bus bus)
        {
            DO.Bus busDAO = new DO.Bus
            {
                License = bus.License,
                GasolineLevel = bus.GasolineLevel,
                TotalTrip = bus.TotalTrip,
                FuelRemain = 0,

                Status = bus.Status
            };
            return busDAO;
        }


        public BO.Bus GetBus(int license)
        {
            DO.Bus busDO;

            try
            {
                busDO = dl.GetBus(license);
            }

            catch (DO.BadBusException excep)
            {
                throw new BO.BadBusException("Bus licence does not exist", excep);
            }

            return AdaptBusToBoToDo(busDO);

        }






        public IEnumerable<BO.Bus> GetAllBus()
        {
            return from item in dl.GetAllBuses()
                   select AdaptBusToBoToDo(item);
        }



        public IEnumerable<BO.Bus> GetAllBuses(BO.Bus bus)
        {
            return bus.ListOfBus;
        }


        public void UpdateBus(BO.Bus bus)
        {
            //Update DO.Person            
            DO.Bus busDO = new DO.Bus();
            bus.CopyPropertiesTo(busDO);
            try
            {
                dl.UpdateBus(busDO);
            }
            catch (DO.BadBusException ex)
            {
                throw new BO.BadBusException("Bus License  is illegal", ex);
            }
        }

        #endregion
    }

}
