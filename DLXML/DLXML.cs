using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using DLXML;
using DO;

//using System.Xml.Linq.Xelement;

using System.Linq;
using DLAPI;

namespace DLXML
{
    sealed class DLXML : IDL
    {
        #region singelton

        static readonly DLXML instance = new DLXML();
        static DLXML() { }
        DLXML() { }
        public static DLXML Instance { get => instance; }
        #endregion


        #region DS XML Files

        string linePath1 = @"lineXml.xml"; //XElement

        string lineStationPath = @"lineStationXml.xml"; //XMLSerializer
        string busPath = @"busXml.xml"; //XMLSerializer

        string adjStationPath = @"adjStationXml.xml"; //XMLSerializer

        string stationPath = @"stationXml.xml"; //XMLSerializer
        string studInCoursesPath = @"StudentInCoureseXml.xml"; //XMLSerializer
        #endregion



        #region Station
        public DO.Station GetStation(int code)//ok
        {
            XElement stationRootElem = XMLTools.LoadListFromXMLElement(stationPath);

            Station p = (from per in stationRootElem.Elements()
                         where int.Parse(per.Element("Code").Value) == code
                         select new Station()
                         {
                             Code = Int32.Parse(per.Element("Code").Value),
                             Name = per.Element("Name").Value,
                             Longitude = Int32.Parse(per.Element("Longitude").Value),
                             Latitude = Int32.Parse(per.Element("Latitude").Value),

                             //City = per.Element("City").Value,
                             //BirthDate = DateTime.Parse(per.Element("BirthDate").Value),
                             //PersonalStatus = (PersonalStatus)Enum.Parse(typeof(PersonalStatus), per.Element("PersonalStatus").Value)
                         }
                        ).FirstOrDefault();

            if (p == null)
                throw new DO.BadStationException(code, $"bad person id: {code}");

            return p;
        }






        public System.Collections.Generic.IEnumerable<DO.Station> GetAllStations() //ok
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



        #endregion Person








        #region Line


        public DO.Line GetLine(int id)//ok
        {
            XElement lineRootElem = XMLTools.LoadListFromXMLElement(linePath1);

            Line p = (from per in lineRootElem.Elements()
                      where int.Parse(per.Element("Code").Value) == cod
                      select new Station()
                      {
                          Code = Int32.Parse(per.Element("Code").Value),
                          Name = per.Element("Name").Value,
                          Longitude = Int32.Parse(per.Element("Longitude").Value),
                          Latitude = Int32.Parse(per.Element("Latitude").Value),

                          //City = per.Element("City").Value,
                          //BirthDate = DateTime.Parse(per.Element("BirthDate").Value),
                          //PersonalStatus = (PersonalStatus)Enum.Parse(typeof(PersonalStatus), per.Element("PersonalStatus").Value)
                      }
                        ).FirstOrDefault();

            if (p == null)
                throw new DO.BadStationException(code, $"bad person id: {code}");

            return p;
        }






        public System.Collections.Generic.IEnumerable<DO.Station> GetAllStations() //ok
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



        #endregion Line



    }

}
