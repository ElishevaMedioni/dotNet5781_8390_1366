using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DS
{
    public static class DataSource
    {
        
        public static List<Station> ListStations = new List<Station>();
        public static List<Line> ListLines = new List<Line>();
        public static List<Bus> Buses = new List<Bus>();
        public static List<LineStation> ListLineStations = new List<LineStation>();
        public static List<AdjacentStations> ListAdjacentStations = new List<AdjacentStations>();
        public static int LineID = 0;

        public static void InitAdjacentStations() { }
        public static void InitLineStations()
        {
            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100000,
                LineStationIndex =0,
                PrevStation = -1,
                NextStation = 100010,
            }) ;

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100010,
                LineStationIndex = 1,
                PrevStation = 100000,
                NextStation = 100020,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100020,
                LineStationIndex = 2,
                PrevStation = 100010,
                NextStation = 100030,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100030,
                LineStationIndex = 3,
                PrevStation = 100020,
                NextStation = 100040,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100040,
                LineStationIndex = 4,
                PrevStation = 100030,
                NextStation = 100050,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100050,
                LineStationIndex = 5,
                PrevStation = 100040,
                NextStation = 100060,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100060,
                LineStationIndex = 6,
                PrevStation = 100050,
                NextStation = 100070,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100070,
                LineStationIndex = 7,
                PrevStation = 100060,
                NextStation = 100080,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100080,
                LineStationIndex = 8,
                PrevStation = 100070,
                NextStation = 100090,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100090,
                LineStationIndex = 9,
                PrevStation = 100080,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100040,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100050,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100050,
                LineStationIndex = 1,
                PrevStation = 100040,
                NextStation = 100020,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100020,
                LineStationIndex = 2,
                PrevStation = 100050,
                NextStation = 100100,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100100,
                LineStationIndex = 3,
                PrevStation = 100020,
                NextStation = 100110,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100110,
                LineStationIndex = 4,
                PrevStation = 100100,
                NextStation = 100120,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100120,
                LineStationIndex = 5,
                PrevStation = 100110,
                NextStation = 100130,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100130,
                LineStationIndex = 6,
                PrevStation = 100120,
                NextStation = 100140,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100140,
                LineStationIndex = 7,
                PrevStation = 100130,
                NextStation = 100150,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100150,
                LineStationIndex = 8,
                PrevStation = 100140,
                NextStation = 100160,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 2,
                Station = 100160,
                LineStationIndex = 9,
                PrevStation = 100150,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100000,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100030,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100030,
                LineStationIndex = 1,
                PrevStation = 100000,
                NextStation = 100090,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100090,
                LineStationIndex = 2,
                PrevStation = 100030,
                NextStation = 100100,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100100,
                LineStationIndex = 3,
                PrevStation = 100090,
                NextStation = 100200,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100200,
                LineStationIndex = 4,
                PrevStation = 100100,
                NextStation = 100210,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100210,
                LineStationIndex = 5,
                PrevStation = 100200,
                NextStation = 100220,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100220,
                LineStationIndex = 6,
                PrevStation = 100210,
                NextStation = 100230,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100230,
                LineStationIndex = 7,
                PrevStation = 100220,
                NextStation = 100240,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100240,
                LineStationIndex = 8,
                PrevStation = 100230,
                NextStation = 100250,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 3,
                Station = 100250,
                LineStationIndex = 9,
                PrevStation = 100240,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100300,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100030,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100030,
                LineStationIndex = 1,
                PrevStation = 100300,
                NextStation = 100320,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100320,
                LineStationIndex = 2,
                PrevStation = 100030,
                NextStation = 100330,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100330,
                LineStationIndex = 3,
                PrevStation = 100320,
                NextStation = 100210,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100210,
                LineStationIndex = 4,
                PrevStation = 100330,
                NextStation = 100340,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100340,
                LineStationIndex = 5,
                PrevStation = 100210,
                NextStation = 100350,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100350,
                LineStationIndex = 6,
                PrevStation = 100340,
                NextStation = 100360,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100360,
                LineStationIndex = 7,
                PrevStation = 100350,
                NextStation = 100370,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100370,
                LineStationIndex = 8,
                PrevStation = 100360,
                NextStation = 100380,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 4,
                Station = 100380,
                LineStationIndex = 9,
                PrevStation = 100370,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100030,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100060,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100060,
                LineStationIndex = 1,
                PrevStation = 100030,
                NextStation = 100010,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100010,
                LineStationIndex = 2,
                PrevStation = 100060,
                NextStation = 100000,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100000,
                LineStationIndex = 3,
                PrevStation = 100010,
                NextStation = 100400,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100400,
                LineStationIndex = 4,
                PrevStation = 100000,
                NextStation = 100410,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100410,
                LineStationIndex = 5,
                PrevStation = 100400,
                NextStation = 100420,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100420,
                LineStationIndex = 6,
                PrevStation = 100410,
                NextStation = 100430,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100430,
                LineStationIndex = 7,
                PrevStation = 100420,
                NextStation = 100440,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100440,
                LineStationIndex = 8,
                PrevStation = 100430,
                NextStation = 100450,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 5,
                Station = 100450,
                LineStationIndex = 9,
                PrevStation = 100440,
                NextStation = -2,
            });
        }
        public static void InitLine()
        {
            ListLines.Add(new Line
            {
                Id  =  LineID++,
                Code=100,
                Area=Areas.CENTER,
                FirstStation=100000,
                LastStation=100050

            });

            ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 101,
                Area = Areas.EAST,
                FirstStation = 100110,
                LastStation = 100160

            }); ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 102,
                Area = Areas.NORTH,
                FirstStation = 100220,
                LastStation = 1000270

            }); ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 103,
                Area = Areas.SOUTH,
                FirstStation = 100300,
                LastStation = 100350

            });
            ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 104,
                Area = Areas.WEST,
                FirstStation = 100430,
                LastStation = 100500

            }); 
            ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 105,
                Area = Areas.CENTER,
                FirstStation = 100020,
                LastStation = 100090

            });
            ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 106,
                Area = Areas.EAST,
                FirstStation = 100120,
                LastStation = 100180

            }); ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 107,
                Area = Areas.NORTH,
                FirstStation = 100210,
                LastStation = 100260

            });
            ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 108,
                Area = Areas.SOUTH,
                FirstStation = 100320,
                LastStation = 100390

            });
            ListLines.Add(new Line
            {
                Id = LineID++,
                Code = 109,
                Area = Areas.WEST,
                FirstStation = 100450,
                LastStation = 1000490

            });
        }
        
        public static void InitBuses()
        {
            Buses.Add(new Bus
            {
                License = 4349870,
                FromDate = DateTime.Today.AddYears(-3),
                TotalTrip = 5555,
                FuelRemain = 1200,
                Status = BusStatus.READY
            });
            Buses.Add(new Bus
            {
                License = 4349875,
                FromDate = DateTime.Today.AddYears(-3),
                TotalTrip = 1018,
                FuelRemain = 15,
                Status = BusStatus.READY
            });
            Buses.Add(new Bus
            {
                License = 56765430,
                FromDate = DateTime.Today.AddYears(0),
                TotalTrip = 20000,
                FuelRemain = 1200,
                Status = BusStatus.INTRAITEMENT
            });

            Buses.Add(new Bus
            {
                License = 1001985,
                FromDate = DateTime.Today.AddYears(-7),
                TotalTrip = 7899,
                FuelRemain = 0,
                Status = BusStatus.ONREFUELING
            });

            Buses.Add(new Bus
            {
                License = 56765435,
                FromDate = DateTime.Today.AddYears(0),
                TotalTrip = 20000,
                FuelRemain = 1200,
                Status = BusStatus.INTRAITEMENT
            });

            Buses.Add(new Bus
            {
                License = 4005435,
                FromDate = DateTime.Today.AddYears(-4),
                TotalTrip = 9076,
                FuelRemain = 555,
                Status = BusStatus.READY
            });


            Buses.Add(new Bus
            {
                License = 1000435,
                FromDate = DateTime.Today.AddYears(-8),
                TotalTrip = 12987,
                FuelRemain = 0,
                Status = BusStatus.ONREFUELING
            });


            Buses.Add(new Bus
            {
                License = 4085430,
                FromDate = DateTime.Today.AddYears(-5),
                TotalTrip = 19076,
                FuelRemain = 554,
                Status = BusStatus.READY
            });


            Buses.Add(new Bus
            {
                License = 58785830,
                FromDate = DateTime.Today.AddYears(0),
                TotalTrip = 12,
                FuelRemain = 1200,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 0000035,
                FromDate = DateTime.Today.AddYears(-10),
                TotalTrip = 17654,
                FuelRemain = 1099,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 40987800,
                FromDate = DateTime.Today.AddYears(-1),
                TotalTrip = 6543,
                FuelRemain = 989,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 58900090,
                FromDate = DateTime.Today.AddYears(-2),
                TotalTrip = 128,
                FuelRemain = 1000,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 1000007,
                FromDate = DateTime.Today.AddYears(-9),
                TotalTrip = 21000,
                FuelRemain = 1200,
                Status = BusStatus.INTRAITEMENT
            });

            Buses.Add(new Bus
            {
                License = 4885800,
                FromDate = DateTime.Today.AddYears(-3),
                TotalTrip = 12987,
                FuelRemain = 0,
                Status = BusStatus.ONREFUELING
            });

            Buses.Add(new Bus
            {
                License = 1098900,
                FromDate = DateTime.Today.AddYears(-9),
                TotalTrip = 16909,
                FuelRemain = 565,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 59898780,
                FromDate = DateTime.Today.AddYears(0),
                TotalTrip = 50,
                FuelRemain = 1148,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 59897785,
                FromDate = DateTime.Today.AddYears(0),
                TotalTrip = 178,
                FuelRemain = 987,
                Status = BusStatus.READY
            });


            Buses.Add(new Bus
            {
                License = 4565000,
                FromDate = DateTime.Today.AddYears(-6),
                TotalTrip = 17098,
                FuelRemain = 734,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 59008000,
                FromDate = DateTime.Today.AddYears(-1),
                TotalTrip = 156,
                FuelRemain = 111,
                Status = BusStatus.READY
            });

            Buses.Add(new Bus
            {
                License = 60000000,
                FromDate = DateTime.Today.AddYears(0),
                TotalTrip = 0,
                FuelRemain = 1200,
                Status = BusStatus.READY
            });









        }
        public static void InitAllStations()
        {

            ListStations.Add(new Station
            {
                Code = 100000,
                Name = "Central Station Jerusalem",
                Longitude = 34.3,
                Latitude = 31,
            });

            ListStations.Add(new Station
            {
                Code = 100010,
                Name = "Mamilla",
                Longitude = 34.4,
                Latitude = 31.1,
            });

            ListStations.Add(new Station
            {
                Code = 100020,
                Name = "Yafo Center",
                Longitude = 34.5,
                Latitude = 31.2,
            });

            ListStations.Add(new Station
            {
                Code = 100030,
                Name = "Kyriat Moshe",
                Longitude = 34.6,
                Latitude = 31.3,
            });

            ListStations.Add(new Station
            {
                Code = 100040,
                Name = "Yefe Nof",
                Longitude = 34.7,
                Latitude = 31.4,
            });

            ListStations.Add(new Station
            {
                Code = 100050,
                Name = "Mahane Yehouda",
                Longitude = 34.5,
                Latitude = 31.5,
            });

            ListStations.Add(new Station
            {
                Code = 100060,
                Name = "Hadavidka",
                Longitude = 34.6,
                Latitude = 31.6,
            });

            ListStations.Add(new Station
            {
                Code = 100070,
                Name = "Hakotel",
                Longitude = 34.7,
                Latitude = 31.2,
            });

            ListStations.Add(new Station
            {
                Code = 100080,
                Name = "Har Hertsel",
                Longitude = 34.5,
                Latitude = 31.7,
            });

            ListStations.Add(new Station
            {
                Code = 100090,
                Name = "Cinema City Jerusalem",
                Longitude = 34.5,
                Latitude = 31.8,
            });

            ListStations.Add(new Station
            {
                Code = 100100,
                Name = "Malha Mall",
                Longitude = 34.5,
                Latitude = 31.8,
            });

            ListStations.Add(new Station
            {
                Code = 100110,
                Name = "Yemin Moshe",
                Longitude = 34.8,
                Latitude = 31.9,
            });

            ListStations.Add(new Station
            {
                Code = 100120,
                Name = "Ben Yehuda",
                Longitude = 34.6,
                Latitude = 31.8,
            });

            ListStations.Add(new Station
            {
                Code = 100130,
                Name = "King George",
                Longitude = 34.9,
                Latitude = 31.9,
            });

            ListStations.Add(new Station
            {
                Code = 100140,
                Name = "Adar Mall",
                Longitude = 35,
                Latitude = 32,
            });

            ListStations.Add(new Station
            {
                Code = 100150,
                Name = "Hillel Street",
                Longitude = 35,
                Latitude = 31.7,
            });

            ListStations.Add(new Station
            {
                Code = 100160,
                Name = "Shaarei Tsedek Hospital",
                Longitude = 35.1,
                Latitude = 31.7,
            });

            ListStations.Add(new Station
            {
                Code = 100170,
                Name = "Hadassa Hospital",
                Longitude = 35,
                Latitude = 31.8,
            });

            ListStations.Add(new Station
            {
                Code = 100180,
                Name = "Yad Vashem",
                Longitude = 35.1,
                Latitude = 31.9,
            });

            ListStations.Add(new Station
            {
                Code = 100190,
                Name = "Museum Israel",
                Longitude = 35.1,
                Latitude = 32,
            });

            ListStations.Add(new Station
            {
                Code = 100200,
                Name = "Givat Ram University",
                Longitude = 35.2,
                Latitude = 31.7,
            });

            ListStations.Add(new Station
            {
                Code = 100210,
                Name = "Har Hatsofim",
                Longitude = 35,
                Latitude = 31.9,
            });

            ListStations.Add(new Station
            {
                Code = 100220,
                Name = "Mahon Lev",
                Longitude = 35.11,
                Latitude = 32.11,
            });

            ListStations.Add(new Station
            {
                Code = 100230,
                Name = "Mahon Tal",
                Longitude = 35.12,
                Latitude = 32.12,
            });

            ListStations.Add(new Station
            {
                Code = 100240,
                Name = "Frishman Beach",
                Longitude = 35.13,
                Latitude = 32.13,
            });

            ListStations.Add(new Station
            {
                Code = 100250,
                Name = "Banana Beach",
                Longitude = 35.14,
                Latitude = 32.14,
            });

            ListStations.Add(new Station
            {
                Code = 100260,
                Name = "Hacarmel Shuk",
                Longitude = 35.15,
                Latitude = 32.15,
            });

            ListStations.Add(new Station
            {
                Code = 100270,
                Name = "Tel Aviv Port",
                Longitude = 35.16,
                Latitude = 32.16,
            });

            ListStations.Add(new Station
            {
                Code = 100280,
                Name = "Rotshild Avenue",
                Longitude = 35.17,
                Latitude = 32.17,
            });

            ListStations.Add(new Station
            {
                Code = 100290,
                Name = "Savidor Center",
                Longitude = 35.18,
                Latitude = 32.18,
            });

            ListStations.Add(new Station
            {
                Code = 100300,
                Name = "Gordon Beach",
                Longitude = 35.19,
                Latitude = 32.19,
            });

            ListStations.Add(new Station
            {
                Code = 100310,
                Name = "Marina Hertzlia",
                Longitude = 35.2,
                Latitude = 32.2,
            });

            ListStations.Add(new Station
            {
                Code = 100320,
                Name = "Bar Ilan University",
                Longitude = 35.21,
                Latitude = 32.21,
            });

            ListStations.Add(new Station
            {
                Code = 100330,
                Name = "Massada",
                Longitude = 35.22,
                Latitude = 32.22,
            });

            ListStations.Add(new Station
            {
                Code = 100340,
                Name = "Ein Gedi",
                Longitude = 35.23,
                Latitude = 32.24,
            });

            ListStations.Add(new Station
            {
                Code = 100350,
                Name = "Meron",
                Longitude = 35.24,
                Latitude = 32.24,
            });

            ListStations.Add(new Station
            {
                Code = 100360,
                Name = "Technion",
                Longitude = 35.25,
                Latitude = 32.25,
            });

            ListStations.Add(new Station
            {
                Code = 100370,
                Name = "Beer Sheva",
                Longitude = 35.26,
                Latitude = 32.26,
            });

            ListStations.Add(new Station
            {
                Code = 100380,
                Name = "Raanana",
                Longitude = 35.28,
                Latitude = 32.27,
            });

            ListStations.Add(new Station
            {
                Code = 100390,
                Name = "Eilat",
                Longitude = 35.29,
                Latitude = 33,
            });

            ListStations.Add(new Station
            {
                Code = 100400,
                Name = "Netivot",
                Longitude = 35.3,
                Latitude = 33.1,
            });

            ListStations.Add(new Station
            {
                Code = 100410,
                Name = "Ashdod",
                Longitude = 35.32,
                Latitude = 33.2,
            });

            ListStations.Add(new Station
            {
                Code = 100420,
                Name = "Bet Shemesh",
                Longitude = 35.33,
                Latitude = 33.12,
            });

            ListStations.Add(new Station
            {
                Code = 100430,
                Name = "Modiin",
                Longitude = 35.34,
                Latitude = 33.13,
            });

            ListStations.Add(new Station
            {
                Code = 100440,
                Name = "Ashkelon",
                Longitude = 35.36,
                Latitude = 33.15,
            });

            ListStations.Add(new Station
            {
                Code = 100450,
                Name = "Dead Sea",
                Longitude = 35.4,
                Latitude = 33.18,
            });

            ListStations.Add(new Station
            {
                Code = 100460,
                Name = "Ikea Rishon Letsion",
                Longitude = 35.42,
                Latitude = 33.2,
            });

            ListStations.Add(new Station
            {
                Code = 100470,
                Name = "Natanya",
                Longitude = 35.44,
                Latitude = 33.25,
            });

            ListStations.Add(new Station
            {
                Code = 100480,
                Name = "Hadera",
                Longitude = 35.46,
                Latitude = 33.27,
            });

            ListStations.Add(new Station
            {
                Code = 100490,
                Name = "Haifa",
                Longitude = 35.48,
                Latitude = 33.28,
            });

            ListStations.Add(new Station
            {
                Code = 100500,
                Name = "Mitspe Ramon",
                Longitude = 35.49,
                Latitude = 33.29,
            });

        }






        static DataSource()
        {
            InitAllStations();
            InitBuses();
            InitLine();
        }







    }






    // Kerennnnn 





}