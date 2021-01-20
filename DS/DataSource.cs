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
        

        public static void InitAdjacentStations()
        {
            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100000,
                Station2 = 100010,
                Distance = 2.15,
                Time = new TimeSpan(0,2,9),
            }); ;

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100010,
                Station2 = 100020,
                Distance = 0.62,
                Time = new TimeSpan(0, 0, 37),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100020,
                Station2 = 100030,
                Distance = 1.9,
                Time = new TimeSpan(0, 1, 54),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100030,
                Station2 = 100040,
                Distance = 1,
                Time = new TimeSpan(0, 4, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100040,
                Station2 = 100050,
                Distance = 2,
                Time = new TimeSpan(0, 10, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100050,
                Station2 = 100060,
                Distance = 1,
                Time = new TimeSpan(0, 9, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100060,
                Station2 = 100070,
                Distance = 2,
                Time = new TimeSpan(0, 9, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100070,
                Station2 = 100080,
                Distance = 4,
                Time = new TimeSpan(0, 14, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100080,
                Station2 = 100090,
                Distance = 2,
                Time = new TimeSpan(0, 9, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100050,
                Station2 = 100020,
                Distance = 1,
                Time = new TimeSpan(0, 2, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100020,
                Station2 = 100100,
                Distance = 5,
                Time = new TimeSpan(0, 16, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100100,
                Station2 = 100110,
                Distance = 5,
                Time = new TimeSpan(0, 18, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100110,
                Station2 = 100120,
                Distance = 1,
                Time = new TimeSpan(0, 5, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100120,
                Station2 = 100130,
                Distance = 0.5,
                Time = new TimeSpan(0, 1, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100130,
                Station2 = 100140,
                Distance = 4.5,
                Time = new TimeSpan(0, 13, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100140,
                Station2 = 100150,
                Distance = 4,
                Time = new TimeSpan(0, 12, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100150,
                Station2 = 100160,
                Distance =7,
                Time = new TimeSpan(0, 22, 21),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100000,
                Station2 = 100030,
                Distance = 1,
                Time = new TimeSpan(0, 3, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100030,
                Station2 = 100090,
                Distance = 1.5,
                Time = new TimeSpan(0, 5, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100090,
                Station2 = 100100,
                Distance = 5,
                Time = new TimeSpan(0, 16, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100100,
                Station2 = 100200,
                Distance = 4,
                Time = new TimeSpan(0, 10, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100200,
                Station2 = 100210,
                Distance = 8,
                Time = new TimeSpan(0, 28, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100210,
                Station2 = 100220,
                Distance = 8.5,
                Time = new TimeSpan(0, 29, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100220,
                Station2 = 100230,
                Distance = 5,
                Time = new TimeSpan(0, 20, 3),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100230,
                Station2 = 100240,
                Distance = 66,
                Time = new TimeSpan(1, 22, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100240,
                Station2 = 100250,
                Distance = 1.5,
                Time = new TimeSpan(0, 5, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100300,
                Station2 = 100030,
                Distance = 67,
                Time = new TimeSpan(1, 29, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100030,
                Station2 = 100320,
                Distance = 53,
                Time = new TimeSpan(1, 3, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100320,
                Station2 = 100330,
                Distance = 125,
                Time = new TimeSpan(2, 28, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100330,
                Station2 = 100210,
                Distance = 20,
                Time = new TimeSpan(0, 28, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100210,
                Station2 = 100340,
                Distance = 68,
                Time = new TimeSpan(1, 15, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100340,
                Station2 = 100350,
                Distance = 245,
                Time = new TimeSpan(4, 48, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100350,
                Station2 = 100360,
                Distance = 30,
                Time = new TimeSpan(0, 44, 27),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100360,
                Station2 = 100370,
                Distance = 305,
                Time = new TimeSpan(5, 58, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100370,
                Station2 = 100380,
                Distance = 268,
                Time = new TimeSpan(4, 25, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100030,
                Station2 = 100060,
                Distance = 2,
                Time = new TimeSpan(0, 8, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100060,
                Station2 = 100010,
                Distance = 2,
                Time = new TimeSpan(0, 15, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100010,
                Station2 = 100000,
                Distance = 2.15,
                Time = new TimeSpan(0, 2, 9),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100000,
                Station2 = 100400,
                Distance = 105,
                Time = new TimeSpan(1, 50, 50),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100400,
                Station2 = 100410,
                Distance = 35,
                Time = new TimeSpan(0, 40, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100410,
                Station2 = 100420,
                Distance = 40,
                Time = new TimeSpan(0, 50, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100420,
                Station2 = 100430,
                Distance = 28,
                Time = new TimeSpan(0, 32, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100430,
                Station2 = 100440,
                Distance = 50,
                Time = new TimeSpan(1, 25, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100440,
                Station2 = 100450,
                Distance = 85,
                Time = new TimeSpan(2, 05, 0),
            });
            

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100450,
                Station2 = 100460,
                Distance = 95,
                Time = new TimeSpan(2, 25, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100460,
                Station2 = 100470,
                Distance = 47,
                Time = new TimeSpan(0, 55, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100470,
                Station2 = 100480,
                Distance = 15,
                Time = new TimeSpan(0, 10, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100480,
                Station2 = 100490,
                Distance = 20,
                Time = new TimeSpan(0, 20, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100490,
                Station2 = 100500,
                Distance = 260,
                Time = new TimeSpan(4, 5, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100500,
                Station2 = 100070,
                Distance = 105,
                Time = new TimeSpan(2, 28, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100050,
                Station2 = 100020,
                Distance = 0.5,
                Time = new TimeSpan(0, 2, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100020,
                Station2 = 100300,
                Distance = 60,
                Time = new TimeSpan(1, 05, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100300,
                Station2 = 100330,
                Distance = 175,
                Time = new TimeSpan(03, 20, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100330,
                Station2 = 100340,
                Distance = 25,
                Time = new TimeSpan(0, 18, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100000,
                Station2 = 100200,
                Distance = 2.6,
                Time = new TimeSpan(0, 12, 0),
            });
          

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100250,
                Station2 = 100260,
                Distance = 4,
                Time = new TimeSpan(0, 17, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100260,
                Station2 = 100270,
                Distance = 8,
                Time = new TimeSpan(0, 26, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100270,
                Station2 = 100280,
                Distance = 2.8,
                Time = new TimeSpan(0, 13, 0),
            });
            
            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100300,
                Station2 = 100030,
                Distance = 67,
                Time = new TimeSpan(1, 29, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100030,
                Station2 = 100320,
                Distance = 50,
                Time = new TimeSpan(0, 50, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100320,
                Station2 = 100110,
                Distance = 55,
                Time = new TimeSpan(0, 53, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100110,
                Station2 = 100210,
                Distance = 6,
                Time = new TimeSpan(0, 28, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100210,
                Station2 = 100310,
                Distance = 80,
                Time = new TimeSpan(1, 42, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100310,
                Station2 = 100410,
                Distance = 80,
                Time = new TimeSpan(1, 25, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100000,
                Station2 = 100110,
                Distance = 3.5,
                Time = new TimeSpan(0, 11, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100110,
                Station2 = 100330,
                Distance = 82,
                Time = new TimeSpan(2, 10, 0),
            });

            ListAdjacentStations.Add(new AdjacentStations
            {
                Station1 = 100330,
                Station2 = 100200,
                Distance = 86,
                Time = new TimeSpan(2, 21, 0),
            });

           

        }
        public static void InitLineStations()
        {
            ListLineStations.Add(new LineStation
            {
                LineId = 1,
                Station = 100000,
                LineStationIndex = 0,
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

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100440,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100450,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100450,
                LineStationIndex = 1,
                PrevStation = 100440,
                NextStation = 100460,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100460,
                LineStationIndex = 2,
                PrevStation = 100450,
                NextStation = 100470,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100470,
                LineStationIndex = 3,
                PrevStation = 100460,
                NextStation = 100480,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100480,
                LineStationIndex = 4,
                PrevStation = 100470,
                NextStation = 100490,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100490,
                LineStationIndex = 5,
                PrevStation = 100480,
                NextStation = 100500,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100500,
                LineStationIndex = 6,
                PrevStation = 100490,
                NextStation = 100070,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100070,
                LineStationIndex = 7,
                PrevStation = 100060,
                NextStation = 100080,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100080,
                LineStationIndex = 8,
                PrevStation = 100070,
                NextStation = 100090,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 6,
                Station = 100090,
                LineStationIndex = 9,
                PrevStation = 100080,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100040,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100050,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100050,
                LineStationIndex = 1,
                PrevStation = 100040,
                NextStation = 100020,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100020,
                LineStationIndex = 2,
                PrevStation = 100050,
                NextStation = 100300,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100300,
                LineStationIndex = 3,
                PrevStation = 100020,
                NextStation = 100330,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100330,
                LineStationIndex = 4,
                PrevStation = 100300,
                NextStation = 100340,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100340,
                LineStationIndex = 5,
                PrevStation = 100330,
                NextStation = 100350,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100350,
                LineStationIndex = 6,
                PrevStation = 100340,
                NextStation = 100360,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100360,
                LineStationIndex = 7,
                PrevStation = 100350,
                NextStation = 100370,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100370,
                LineStationIndex = 8,
                PrevStation = 100360,
                NextStation = 100380,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 7,
                Station = 100380,
                LineStationIndex = 9,
                PrevStation = 100370,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100000,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100200,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100200,
                LineStationIndex = 1,
                PrevStation = 100000,
                NextStation = 100210,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100210,
                LineStationIndex = 2,
                PrevStation = 100200,
                NextStation = 100220,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100220,
                LineStationIndex = 3,
                PrevStation = 100210,
                NextStation = 100230,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100230,
                LineStationIndex = 4,
                PrevStation = 100220,
                NextStation = 100240,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100240,
                LineStationIndex = 5,
                PrevStation = 100230,
                NextStation = 100250,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100250,
                LineStationIndex = 6,
                PrevStation = 100240,
                NextStation = 100260,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100260,
                LineStationIndex = 7,
                PrevStation = 100250,
                NextStation = 100270,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100270,
                LineStationIndex = 8,
                PrevStation = 100260,
                NextStation = 100280,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 8,
                Station = 100280,
                LineStationIndex = 9,
                PrevStation = 100270,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100300,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100030,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100030,
                LineStationIndex = 1,
                PrevStation = 100300,
                NextStation = 100320,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100320,
                LineStationIndex = 2,
                PrevStation = 100030,
                NextStation = 100110,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100110,
                LineStationIndex = 3,
                PrevStation = 100320,
                NextStation = 100210,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100210,
                LineStationIndex = 4,
                PrevStation = 100110,
                NextStation = 100310,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100310,
                LineStationIndex = 5,
                PrevStation = 100210,
                NextStation = 100410,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100410,
                LineStationIndex = 6,
                PrevStation = 100310,
                NextStation = 100420,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100420,
                LineStationIndex = 7,
                PrevStation = 100410,
                NextStation = 100430,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100430,
                LineStationIndex = 8,
                PrevStation = 100420,
                NextStation = 100440,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 9,
                Station = 100440,
                LineStationIndex = 9,
                PrevStation = 100430,
                NextStation = -2,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100450,
                LineStationIndex = 0,
                PrevStation = -1,
                NextStation = 100460,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100460,
                LineStationIndex = 1,
                PrevStation = 100450,
                NextStation = 100470,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100470,
                LineStationIndex = 2,
                PrevStation = 100460,
                NextStation = 100480,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100480,
                LineStationIndex = 3,
                PrevStation = 100470,
                NextStation = 100490,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100490,
                LineStationIndex = 4,
                PrevStation = 100480,
                NextStation = 100500,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100500,
                LineStationIndex = 5,
                PrevStation = 100490,
                NextStation = 100000,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100000,
                LineStationIndex = 6,
                PrevStation = 100500,
                NextStation = 100110,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100110,
                LineStationIndex = 7,
                PrevStation = 100000,
                NextStation = 100330,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100330,
                LineStationIndex = 8,
                PrevStation = 100110,
                NextStation = 100200,
            });

            ListLineStations.Add(new LineStation
            {
                LineId = 10,
                Station = 100200,
                LineStationIndex = 9,
                PrevStation = 100330,
                NextStation = -2,
            });
        }
        public static void InitLine()
        {
            ListLines.Add(new Line
            {
                Id = LineID++, //1
                Code = 100,
                Area = Areas.CENTER,
                FirstStation = 100000,
                LastStation = 100090

            });

            ListLines.Add(new Line
            {
                Id = LineID++, //2
                Code = 101,
                Area = Areas.EAST,
                FirstStation = 100040,
                LastStation = 100160

            }); ListLines.Add(new Line
            {
                Id = LineID++, //3
                Code = 102,
                Area = Areas.NORTH,
                FirstStation = 100000,
                LastStation = 100250

            }); ListLines.Add(new Line
            {
                Id = LineID++, //4
                Code = 103,
                Area = Areas.SOUTH,
                FirstStation = 100300,
                LastStation = 100380

            });
            ListLines.Add(new Line
            {
                Id = LineID++, //5
                Code = 104,
                Area = Areas.WEST,
                FirstStation = 100030,
                LastStation = 100450

            }); 
            ListLines.Add(new Line
            {
                Id = LineID++, //6
                Code = 105,
                Area = Areas.CENTER,
                FirstStation = 100440,
                LastStation = 100090

            });
            ListLines.Add(new Line
            {
                Id = LineID++, //7
                Code = 106,
                Area = Areas.EAST,
                FirstStation = 100040,
                LastStation = 100380

            }); ListLines.Add(new Line
            {
                Id = LineID++, //8
                Code = 107,
                Area = Areas.NORTH,
                FirstStation = 100000,
                LastStation = 100280

            });
            ListLines.Add(new Line
            {
                Id = LineID++, //9
                Code = 108,
                Area = Areas.SOUTH,
                FirstStation = 100300,
                LastStation = 100440

            });
            ListLines.Add(new Line
            {
                Id = LineID++, //10
                Code = 109,
                Area = Areas.WEST,
                FirstStation = 100450,
                LastStation = 100200

            });
            ListLines.Add(new Line
            {
                Id = LineID++, //11
                Code = 110,
                Area = Areas.WEST,
                FirstStation = 100450,
                LastStation = 100490

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
                Longitude = 35.20268,
                Latitude = 31.78884,
                
            });

            ListStations.Add(new Station
            {
                Code = 100010,
                Name = "Mamilla",
                Longitude = 35.22182,
                Latitude = 31.77842,
            });

            ListStations.Add(new Station
            {
                Code = 100020,
                Name = "Yafo Center",
                Longitude = 35.21816 ,
                Latitude = 31.78309,
            });

            ListStations.Add(new Station
            {
                Code = 100030,
                Name = "Kyriat Moshe",
                Longitude = 35.19842 ,
                Latitude = 31.78669 ,
            });

            ListStations.Add(new Station
            {
                Code = 100040,
                Name = "Yefe Nof",
                Longitude = 35.18470,
                Latitude = 31.77680,
            });

            ListStations.Add(new Station
            {
                Code = 100050,
                Name = "Mahane Yehouda",
                Longitude = 35.21190,
                Latitude = 31.78439,
            });

            ListStations.Add(new Station
            {
                Code = 100060,
                Name = "Hadavidka",
                Longitude = 35.21529,
                Latitude = 31.78460,
            });

            ListStations.Add(new Station
            {
                Code = 100070,
                Name = "Hakotel",
                Longitude = 35.23323 ,
                Latitude = 31.77653,
            });

            ListStations.Add(new Station
            {
                Code = 100080,
                Name = "Har Hertsel",
                Longitude = 35.18161,
                Latitude = 31.77094,
            });

            ListStations.Add(new Station
            {
                Code = 100090,
                Name = "Cinema City Jerusalem",
                Longitude = 35.20363,
                Latitude = 31.78312,
            });

            ListStations.Add(new Station
            {
                Code = 100100,
                Name = "Malha Mall",
                Longitude = 35.18716,
                Latitude = 31.75165,
            });

            ListStations.Add(new Station
            {
                Code = 100110,
                Name = "Yemin Moshe",
                Longitude = 35.22512,
                Latitude = 31.77364,
            });

            ListStations.Add(new Station
            {
                Code = 100120,
                Name = "Ben Yehuda",
                Longitude = 35.21658,
                Latitude = 31.78137,
            });

            ListStations.Add(new Station
            {
                Code = 100130,
                Name = "King George",
                Longitude = 35.21917,
                Latitude = 31.77962,
            });

            ListStations.Add(new Station
            {
                Code = 100140,
                Name = "Adar Mall",
                Longitude = 35.21343,
                Latitude = 31.7537,
            });

            ListStations.Add(new Station
            {
                Code = 100150,
                Name = "Hillel Street",
                Longitude = 35.21862,
                Latitude = 31.7802 ,
            });

            ListStations.Add(new Station
            {
                Code = 100160,
                Name = "Shaarei Tsedek Hospital",
                Longitude = 35.18527,
                Latitude = 31.77332,
            });

            ListStations.Add(new Station
            {
                Code = 100170,
                Name = "Hadassa Hospital",
                Longitude = 35.24225,
                Latitude = 31.79755,
            });

            ListStations.Add(new Station
            {
                Code = 100180,
                Name = "Yad Vashem",
                Longitude = 35.17532,
                Latitude = 31.77422,
            });

            ListStations.Add(new Station
            {
                Code = 100190,
                Name = "Museum Israel",
                Longitude = 35.20409,
                Latitude = 31.77221,
            });

            ListStations.Add(new Station
            {
                Code = 100200,
                Name = "Givat Ram University",
                Longitude = 35.24082,
                Latitude = 31.79464
,
            });

            ListStations.Add(new Station
            {
                Code = 100210,
                Name = "Har Hatsofim",
                Longitude = 35.20955,
                Latitude = 31.80311,
            });

            ListStations.Add(new Station
            {
                Code = 100220,
                Name = "Mahon Lev",
                Longitude = 35.19116,
                Latitude = 31.76507,
            });

            ListStations.Add(new Station
            {
                Code = 100230,
                Name = "Mahon Tal",
                Longitude = 35.1897,
                Latitude = 31.7857,
            });

            ListStations.Add(new Station
            {
                Code = 100240,
                Name = "Frishman Beach",
                Longitude = 34.76678,
                Latitude = 32.08036,
            });

            ListStations.Add(new Station
            {
                Code = 100250,
                Name = "Banana Beach",
                Longitude = 34.76325,
                Latitude = 32.07105,
            });

            ListStations.Add(new Station
            {
                Code = 100260,
                Name = "Hacarmel Shuk",
                Longitude = 34.77084,
                Latitude = 32.06891,
            });

            ListStations.Add(new Station
            {
                Code = 100270,
                Name = "Tel Aviv Port",
                Longitude = 34.77410,
                Latitude = 32.09878,
            });

            ListStations.Add(new Station
            {
                Code = 100280,
                Name = "Rotshild Avenue",
                Longitude = 34.77658,
                Latitude = 32.06570,
            });

            ListStations.Add(new Station
            {
                Code = 100290,
                Name = "Savidor Center",
                Longitude = 34.79813,
                Latitude = 32.08366,
            });

            ListStations.Add(new Station
            {
                Code = 100300,
                Name = "Gordon Beach",
                Longitude = 34.76786,
                Latitude = 32.08288,
            });

            ListStations.Add(new Station
            {
                Code = 100310,
                Name = "Marina Hertzlia",
                Longitude = 34.79625,
                Latitude = 32.16312,
            });

            ListStations.Add(new Station
            {
                Code = 100320,
                Name = "Bar Ilan University",
                Longitude = 34.84319,
                Latitude = 32.06880,
            });

            ListStations.Add(new Station
            {
                Code = 100330,
                Name = "Massada",
                Longitude = 35.36298,
                Latitude = 31.31187,
            });

            ListStations.Add(new Station
            {
                Code = 100340,
                Name = "Ein Gedi",
                Longitude = 35.38731,
                Latitude = 31.45330,
            });

            ListStations.Add(new Station
            {
                Code = 100350,
                Name = "Meron",
                Longitude = 35.44019,
                Latitude = 32.99068,
            });

            ListStations.Add(new Station
            {
                Code = 100360,
                Name = "Technion",
                Longitude = 35.02269,
                Latitude = 32.77652,
            });

            ListStations.Add(new Station
            {
                Code = 100370,
                Name = "Beer Sheva",
                Longitude = 34.79363,
                Latitude = 31.24939,
            });

            ListStations.Add(new Station
            {
                Code = 100380,
                Name = "Raanana",
                Longitude = 34.87645,
                Latitude = 32.17986,
            });

            ListStations.Add(new Station
            {
                Code = 100390,
                Name = "Eilat",
                Longitude = 34.93620,
                Latitude = 29.55272,
            });

            ListStations.Add(new Station
            {
                Code = 100400,
                Name = "Netivot",
                Longitude = 34.57231,
                Latitude = 31.41080,
            });

            ListStations.Add(new Station
            {
                Code = 100410,
                Name = "Ashdod",
                Longitude = 34.65472,
                Latitude = 31.81113,
            });

            ListStations.Add(new Station
            {
                Code = 100420,
                Name = "Bet Shemesh",
                Longitude = 34.98766,
                Latitude = 31.75784,
            });

            ListStations.Add(new Station
            {
                Code = 100430,
                Name = "Modiin",
                Longitude = 35.00263,
                Latitude = 31.90883,
            });

            ListStations.Add(new Station
            {
                Code = 100440,
                Name = "Ashkelon",
                Longitude = 34.56389,
                Latitude = 31.65949,
            });

            ListStations.Add(new Station
            {
                Code = 100450,
                Name = "Dead Sea",
                Longitude = 35.58651,
                Latitude = 31.71867,
            });

            ListStations.Add(new Station
            {
                Code = 100460,
                Name = "Ikea Rishon Letsion",
                Longitude = 34.77143,
                Latitude = 31.95148,
            });

            ListStations.Add(new Station
            {
                Code = 100470,
                Name = "Natanya",
                Longitude = 34.85054,
                Latitude = 32.32352,
            });

            ListStations.Add(new Station
            {
                Code = 100480,
                Name = "Hadera",
                Longitude = 34.88549,
                Latitude = 32.47199,
            });

            ListStations.Add(new Station
            {
                Code = 100490,
                Name = "Haifa",
                Longitude = 34.98863,
                Latitude = 32.82506,
            });

            ListStations.Add(new Station
            {
                Code = 100500,
                Name = "Mitspe Ramon",
                Longitude = 34.79903,
                Latitude = 30.60805,
            });

        }






        static DataSource()
        {
            InitAllStations();
            InitLineStations();
            InitBuses();
            InitLine();
            InitAdjacentStations();
        }







    }






    // Kerennnnn 





}