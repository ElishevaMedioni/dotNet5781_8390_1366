using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

using DO;


using System.Linq;
using DLAPI;
using System.Collections.Generic;

namespace DL
{
    sealed class DLXML1 : IDL
    {
        #region singelton

        static readonly DLXML1 instance = new DLXML1();
        static DLXML1() { }
        DLXML1() { }
        public static DLXML1 Instance { get => instance; }
        #endregion


        #region DS XML Files

        string linePath1 = @"lineXml.xml"; //XElement

        string lineStationPath = @"lineStationXml.xml"; //XMLSerializer
        string busPath = @"busXml.xml"; //XMLSerializer

       

        string stationPath = @"stationXml.xml"; //XMLSerializer
        
        #endregion



        #region Station
        public DO.Station GetStation(int code)//ok
        {
            XElement stationRootElem = XMLTools.LoadListFromXMLElement(stationPath); //

            Station p = (from per in stationRootElem.Elements()
                         where int.Parse(per.Element("Code").Value) == code
                         select new Station()
                         {
                             Code = Int32.Parse(per.Element("Code").Value),
                             Name = per.Element("Name").Value,
                             Longitude = Int32.Parse(per.Element("Longitude").Value),
                             Latitude = Int32.Parse(per.Element("Latitude").Value),


                         }
                        ).FirstOrDefault();

            if (p == null)
                throw new DO.BadStationException(code, $"bad person id: {code}");

            return p;
        }






        public IEnumerable<DO.Station> GetAllStations() //ok
        {
            XElement stationRootElem = XMLTools.LoadListFromXMLElement(stationPath);

            return (from p in stationRootElem.Elements()
                    select new Station()
                    {
                        Code = Int32.Parse(p.Element("Code").Value),
                        Name = p.Element("Name").Value,
                        Longitude = Int32.Parse(p.Element("Longitude").Value),
                        Latitude = Int32.Parse(p.Element("Latitude").Value),
                    }
                   );
        }







        public void AddStation(DO.Station station) // ok
        {
            XElement stationRootElem = XMLTools.LoadListFromXMLElement(stationPath);

            XElement per1 = (from p in stationRootElem.Elements()
                             where int.Parse(p.Element("Code").Value) == station.Code
                             select p).FirstOrDefault();

            if (per1 != null)
                throw new DO.BadStationException(station.Code, "Duplicate station code");

            XElement stationElem = new XElement("Station",
                                   new XElement("Code", station.Code),
                                   new XElement("Name", station.Name),
                                   new XElement("Longitude", station.Longitude),
                                   new XElement("Latitude", station.Latitude));

            stationRootElem.Add(stationElem);

            XMLTools.SaveListToXMLElement(stationRootElem, stationPath);
        }



        public void DeleteStation(int code) //OK
        {
            XElement stationRootElem = XMLTools.LoadListFromXMLElement(stationPath);

            XElement per = (from p in stationRootElem.Elements()
                            where int.Parse(p.Element("ID").Value) == code
                            select p).FirstOrDefault();

            if (per != null)
            {
                per.Remove();
                XMLTools.SaveListToXMLElement(stationRootElem, stationPath);
            }
            else
                throw new DO.BadStationException(code, $"bad person id: {code}");
        }




        public void UpdateStation(DO.Station station)
        {
            XElement stationRootElem = XMLTools.LoadListFromXMLElement(stationPath);

            XElement per = (from p in stationRootElem.Elements()
                            where int.Parse(p.Element("ID").Value) == station.Code
                            select p).FirstOrDefault();

            if (per != null)
            {
                per.Element("Code").Value = station.Code.ToString();
                per.Element("Name").Value = station.Name;
                per.Element("Longitude").Value = station.Longitude.ToString();
                per.Element("Latitude").Value = station.Latitude.ToString();


                XMLTools.SaveListToXMLElement(stationRootElem, stationPath);
            }
            else
                throw new DO.BadStationException(station.Code, $"bad station code: {station.Code}");
        }



        #endregion Station








        #region Line


        public DO.Line GetLine(int id)
        {
            XElement lineRootElem = XMLTools.LoadListFromXMLElement(linePath1);

            Line p = (from per in lineRootElem.Elements()
                      where int.Parse(per.Element("Id").Value) == id
                      select new Line()
                      {
                          Id = Int32.Parse(per.Element("Id").Value),
                          Code = Int32.Parse(per.Element("Code").Value),
                          FirstStation = Int32.Parse(per.Element(" FirtStation").Value),
                          LastStation = Int32.Parse(per.Element("LastStation").Value),
                          Area = (Areas)Enum.Parse(typeof(Areas), per.Element("Areas").Value)

                      }
                        ).FirstOrDefault();

            if (p == null)
                throw new DO.BadLineIdException(id, $"bad person id: {id}");

            return p;
        }






        public IEnumerable<DO.Line> GetAllLines()
        {
            XElement lineRootElem = XMLTools.LoadListFromXMLElement(linePath1);

            return (from per in lineRootElem.Elements()
                    select new Line()
                    {
                        Id = Int32.Parse(per.Element("Id").Value),
                        Code = Int32.Parse(per.Element("Code").Value),
                        FirstStation = Int32.Parse(per.Element(" FirtStation").Value),
                        LastStation = Int32.Parse(per.Element("LastStation").Value),
                        Area = (Areas)Enum.Parse(typeof(Areas), per.Element("Areas").Value)
                    }
                   );
        }







        public int AddLine(DO.Line line)  //PB IL FAUT QUE CA SOIT INT
        {
            XElement dlConfig = XElement.Load(@"config.xml");
            int LineBusId = int.Parse(dlConfig.Element("LineID").Value);



            XElement lineRootElem = XMLTools.LoadListFromXMLElement(linePath1);

            XElement per1 = (from per in lineRootElem.Elements()
                             where int.Parse(per.Element("Id").Value) == line.Id
                             select per).FirstOrDefault();

            if (per1 != null)
                throw new DO.BadLineIdException(line.Code, "Duplicate Line code");


            line.Id = LineBusId++;
            XElement lineElem = new XElement("Id",
                                   new XElement("Code", line.Code),
                                   new XElement("FirtStation", line.FirstStation),
                                   new XElement("LastStation", line.LastStation),
                                   new XElement("Areas", line.Area));

            lineRootElem.Add(lineElem);

            XMLTools.SaveListToXMLElement(lineRootElem, linePath1);
            dlConfig.Save(@"config.xml");

            return LineBusId;
        }



        public void DeleteLine(int id) //OK
        {
            XElement lineRootElem = XMLTools.LoadListFromXMLElement(linePath1);

            XElement per = (from p in lineRootElem.Elements()
                            where int.Parse(p.Element("ID").Value) == id
                            select p).FirstOrDefault();

            if (per != null)
            {
                per.Remove();
                XMLTools.SaveListToXMLElement(lineRootElem, linePath1);
            }
            else
                throw new DO.BadLineIdException(id, $"bad person id: {id}");
        }




        public void UpdateLine(DO.Line line)
        {
            XElement lineRootElem = XMLTools.LoadListFromXMLElement(linePath1);

            XElement per = (from p in lineRootElem.Elements()
                            where int.Parse(p.Element("ID").Value) == line.Code
                            select p).FirstOrDefault();

            if (per != null)
            {
                per.Element(" Id").Value = line.Id.ToString();
                per.Element(" Code").Value = line.Code.ToString();
                per.Element("Area").Value = line.Area.ToString();
                per.Element("FirstStation").Value = line.FirstStation.ToString();
                per.Element("LastStation").Value = line.LastStation.ToString();


                XMLTools.SaveListToXMLElement(lineRootElem, linePath1);


            }
            else
                throw new DO.BadLineCodeException(line.Code, $"bad line code: {line.Code}");
        }

       


        #endregion Line






        #region Bus




        public IEnumerable<DO.Bus> GetAllBuses()
        {
            XElement busRootElem = XMLTools.LoadListFromXMLElement(busPath);

            return (from per in busRootElem.Elements()
                    select new Bus()
                    {
                        License = Int32.Parse(per.Element("License").Value),
                        TotalTrip = Int32.Parse(per.Element("TotalTrip").Value),
                        FuelRemain = Int32.Parse(per.Element("FuelRemain").Value),
                        GasolineLevel = Int32.Parse(per.Element("GasolineLevel").Value),
                        Status = (BusStatus)Enum.Parse(typeof(Areas), per.Element("Areas").Value),
                        FromDate = DateTime.Parse(per.Element("FromDate").Value)
                    }
                   );
        }


        public DO.Bus GetBus(int license)
        {
            XElement busRootElem = XMLTools.LoadListFromXMLElement(busPath);

            Bus p = (from per in busRootElem.Elements()
                     where int.Parse(per.Element("License").Value) == license
                     select new Bus()
                     {
                         License = Int32.Parse(per.Element("License").Value),
                         TotalTrip = Int32.Parse(per.Element("TotalTrip").Value),
                         FuelRemain = Int32.Parse(per.Element("FuelRemain").Value),
                         GasolineLevel = Int32.Parse(per.Element("GasolineLevel").Value),
                         Status = (BusStatus)Enum.Parse(typeof(Areas), per.Element("Areas").Value),
                         FromDate = DateTime.Parse(per.Element("FromDate").Value)

                     }
                        ).FirstOrDefault();

            if (p == null)
                throw new DO.BadBusException(license, $"bad bus id: {license}");

            return p;
        }


        public void UpdateBus(DO.Bus bus)
        {
            XElement busRootElem = XMLTools.LoadListFromXMLElement(busPath);


            XElement per = (from p in busRootElem.Elements()
                            where int.Parse(p.Element("License").Value) == bus.License
                            select p).FirstOrDefault();

            if (per != null)
            {
                per.Element("License").Value = bus.License.ToString();
                per.Element("TotalTrip").Value = bus.TotalTrip.ToString();
                per.Element("FuelRemain").Value = bus.FuelRemain.ToString();
                per.Element("GasolineLevel").Value = bus.GasolineLevel.ToString();
                per.Element("Status").Value = bus.Status.ToString();
                per.Element("FromDate").Value = bus.FromDate.ToString();

                XMLTools.SaveListToXMLElement(busRootElem, busPath);


            }
            else
                throw new DO.BadBusException(bus.License, $"bad line code: {bus.License}");
        }



        #endregion Bus














        #region LineStation




        public DO.LineStation GetLineStation(int lineId, int station)
        {
            XElement lineStationRootElem = XMLTools.LoadListFromXMLElement(lineStationPath);

            LineStation p = (from per in lineStationRootElem.Elements()
                             where int.Parse(per.Element("lineId").Value) == lineId && int.Parse(per.Element("station").Value) == station
                             select new LineStation()
                             {
                                 LineId = Int32.Parse(per.Element("LineId").Value),
                                 Station = Int32.Parse(per.Element("Station").Value),
                                 LineStationIndex = Int32.Parse(per.Element("LineStationIndex").Value)

                             }
                         ).FirstOrDefault();

            if (p == null)
                throw new DO.BadLineStationException(lineId, $"bad LineStation id: {lineId}");

            return p;
        }


        public IEnumerable<DO.LineStation> GetAllLineStations()
        {
            XElement lineStationRootElem = XMLTools.LoadListFromXMLElement(lineStationPath);

            return (from per in lineStationRootElem.Elements()
                    select new LineStation()
                    {
                        LineId = Int32.Parse(per.Element("LineId").Value),
                        Station = Int32.Parse(per.Element("Station").Value),
                        LineStationIndex = Int32.Parse(per.Element("LineStationIndex").Value)
                    }
                   );
        }



        public void AddLineStation(DO.LineStation lineStation)
        {




            XElement lineStationRootElem = XMLTools.LoadListFromXMLElement(lineStationPath);

            XElement per1 = (from per in lineStationRootElem.Elements()
                             where int.Parse(per.Element("lineId").Value) == lineStation.LineId && int.Parse(per.Element("station").Value) == lineStation.Station
                             select per).FirstOrDefault();

            if (per1 != null)
                throw new DO.BadLineStationException(lineStation.LineId, "Duplicate LineStation code");


            XElement lineStationElem = new XElement("LineId",
                                   new XElement("Station", lineStation.Station),
                                   new XElement("LineStationIndex", lineStation.LineStationIndex));


            lineStationRootElem.Add(lineStationElem);

            XMLTools.SaveListToXMLElement(lineStationRootElem, lineStationPath);



        }


        public void UpdateLineStation(DO.LineStation lineStation)
        {
            XElement lineStationRootElem = XMLTools.LoadListFromXMLElement(lineStationPath);


            XElement per = (from p in lineStationRootElem.Elements()
                            where int.Parse(p.Element("lineId").Value) == lineStation.LineId && int.Parse(p.Element("station").Value) == lineStation.Station
                            select p).FirstOrDefault();

            if (per != null)
            {
                per.Element("LineId").Value = lineStation.LineId.ToString();
                per.Element("Station").Value = lineStation.Station.ToString();
                per.Element("LineStationIndex").Value = lineStation.LineStationIndex.ToString();
                XMLTools.SaveListToXMLElement(lineStationRootElem, lineStationPath);


            }
            else
                throw new DO.BadLineStationException(lineStation.LineId, "Duplicate LineStation code");
        }

        public DO.LineStation UpdateLineStation2(DO.LineStation lineStation)
        {


            return null;

            //tu veux je ten
        }



        public void DeleteLineStation(int lineId, int station) //OK
        {
            XElement lineStationRootElem = XMLTools.LoadListFromXMLElement(lineStationPath);

            XElement per = (from p in lineStationRootElem.Elements()
                            where int.Parse(p.Element("LineID").Value) == lineId && int.Parse(p.Element("Station").Value) == station
                            select p).FirstOrDefault();

            if (per != null)
            {
                per.Remove();
                XMLTools.SaveListToXMLElement(lineStationRootElem, lineStationPath);
            }
            else
                throw new DO.BadLineStationException(lineId, $"bad person id: {lineId}");
        }

        public void DeleteStationToAllLines(int station)
        {
            
            List<LineStation> lineStations = XMLTools.LoadListFromXMLSerializer<LineStation>(lineStationPath);
            lineStations.RemoveAll(p => p.Station == station);
            XMLTools.SaveListToXMLSerializer(lineStations, lineStationPath);


        }

        public IEnumerable<DO.LineStation> GetLineStationInLineStationsList(Predicate<DO.LineStation> predicate)
        {
            XElement lineStationRootElem = XMLTools.LoadListFromXMLElement(lineStationPath);

            IEnumerable<LineStation> enumerable = from p in lineStationRootElem.Elements()

            let ls = new LineStation()
            {
                LineId = Int32.Parse(p.Element("LineId").Value),
                Station = Int32.Parse(p.Element("Station").Value),
                LineStationIndex = Int32.Parse(p.Element("LineStationIndex").Value),
            }
            where predicate(ls)
            select ls;

            IEnumerable<DO.LineStation> lst = enumerable.OrderBy(i => i.LineStationIndex);

            return lst;

        }

        #endregion LineStation









    }

}
