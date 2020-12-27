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
        //elisheva
        public static List<Station> Station = new List<Station>();
       //Keke
        private static List<LineTrip> busestravel = new List<LineTrip>();
        private static List<Bus> buses = new List<Bus>();
        public static List<Bus> Buses { get => buses; }
        public static List<LineTrip> BusesTravel { get => busestravel; }

        public static void initBuses()
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
                License =56765430,
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
        public static void InitAllLists()
        {

            Station.Add(new Station
                {
                    Code = 100000,
                    Name = "Central Station Jerusalem",
                    Longitude = 34.3,
                    Latitude = 31,
                 }) ;

            Station.Add(new Station
            {
                Code = 100010,
                Name = "Mamilla",
                Longitude = 34.4,
                Latitude = 31.1,
            });

            Station.Add(new Station
            {
                Code = 100020,
                Name = "Yafo Center",
                Longitude = 34.5,
                Latitude = 31.2,
            });

            Station.Add(new Station
            {
                Code = 100030,
                Name = "Kyriat Moshe",
                Longitude = 34.6,
                Latitude = 31.3,
            });

            Station.Add(new Station
            {
                Code = 100040,
                Name = "Yefe Nof",
                Longitude = 34.7,
                Latitude = 31.4,
            });

            Station.Add(new Station
            {
                Code = 100050,
                Name = "Mahane Yehouda",
                Longitude = 34.5,
                Latitude = 31.5,
            });

            Station.Add(new Station
            {
                Code = 100060,
                Name = "Hadavidka",
                Longitude = 34.6,
                Latitude = 31.6,
            });

            Station.Add(new Station
            {
                Code = 100070,
                Name = "Hakotel",
                Longitude = 34.7,
                Latitude = 31.2,
            });

            Station.Add(new Station
            {
                Code = 100080,
                Name = "Har Hertsel",
                Longitude = 34.5,
                Latitude = 31.7,
            });

            Station.Add(new Station
            {
                Code = 100090,
                Name = "Cinema City Jerusalem",
                Longitude = 34.5,
                Latitude = 31.8,
            });

            Station.Add(new Station
            {
                Code = 100100,
                Name = "Malha Mall",
                Longitude = 34.5,
                Latitude = 31.8,
            });

            Station.Add(new Station
            {
                Code = 100110,
                Name = "Yemin Moshe",
                Longitude = 34.8,
                Latitude = 31.9,
            });

            Station.Add(new Station
            {
                Code = 100120,
                Name = "Ben Yehuda",
                Longitude = 34.6,
                Latitude = 31.8,
            });

            Station.Add(new Station
            {
                Code = 100130,
                Name = "King George",
                Longitude = 34.9,
                Latitude = 31.9,
            });

            Station.Add(new Station
            {
                Code = 100140,
                Name = "Adar Mall",
                Longitude = 35,
                Latitude = 32,
            });

            Station.Add(new Station
            {
                Code = 100150,
                Name = "Hillel Street",
                Longitude = 35,
                Latitude = 31.7,
            });

            Station.Add(new Station
            {
                Code = 100160,
                Name = "Shaarei Tsedek Hospital",
                Longitude = 35.1,
                Latitude = 31.7,
            });

            Station.Add(new Station
            {
                Code = 100170,
                Name = "Hadassa Hospital",
                Longitude = 35,
                Latitude = 31.8,
            });

            Station.Add(new Station
            {
                Code = 100180,
                Name = "Yad Vashem",
                Longitude = 35.1,
                Latitude = 31.9,
            });

            Station.Add(new Station
            {
                Code = 100190,
                Name = "Museum Israel",
                Longitude = 35.1,
                Latitude = 32,
            });

            Station.Add(new Station
            {
                Code = 100200,
                Name = "Givat Ram University",
                Longitude = 35.2,
                Latitude = 31.7,
            });

            Station.Add(new Station
            {
                Code = 100210,
                Name = "Har Hatsofim",
                Longitude = 35,
                Latitude = 31.9,
            });

            Station.Add(new Station
            {
                Code = 100220,
                Name = "Mahon Lev",
                Longitude = 35.11,
                Latitude = 32.11,
            });

            Station.Add(new Station
            {
                Code = 100230,
                Name = "Mahon Tal",
                Longitude = 35.12,
                Latitude = 32.12,
            });

            Station.Add(new Station
            {
                Code = 100240,
                Name = "Frishman Beach",
                Longitude = 35.13,
                Latitude = 32.13,
            });

            Station.Add(new Station
            {
                Code = 100250,
                Name = "Banana Beach",
                Longitude = 35.14,
                Latitude = 32.14,
            });

            Station.Add(new Station
            {
                Code = 100260,
                Name = "Hacarmel Shuk",
                Longitude = 35.15,
                Latitude = 32.15,
            });

            Station.Add(new Station
            {
                Code = 100270,
                Name = "Tel Aviv Port",
                Longitude = 35.16,
                Latitude = 32.16,
            });

            Station.Add(new Station
            {
                Code = 100280,
                Name = "Rotshild Avenue",
                Longitude = 35.17,
                Latitude = 32.17,
            });

            Station.Add(new Station
            {
                Code = 100290,
                Name = "Savidor Center",
                Longitude = 35.18,
                Latitude = 32.18,
            });

            Station.Add(new Station
            {
                Code = 100300,
                Name = "Gordon Beach",
                Longitude = 35.19,
                Latitude = 32.19,
            });

            Station.Add(new Station
            {
                Code = 100310,
                Name = "Marina Hertzlia",
                Longitude = 35.2,
                Latitude = 32.2,
            });

            Station.Add(new Station
            {
                Code = 100320,
                Name = "Bar Ilan University",
                Longitude = 35.21,
                Latitude = 32.21,
            });

            Station.Add(new Station
            {
                Code = 100330,
                Name = "Massada",
                Longitude = 35.22,
                Latitude = 32.22,
            });

            Station.Add(new Station
            {
                Code = 100340,
                Name = "Ein Gedi",
                Longitude = 35.23,
                Latitude = 32.24,
            });

            Station.Add(new Station
            {
                Code = 100350,
                Name = "Meron",
                Longitude = 35.24,
                Latitude = 32.24,
            });

            Station.Add(new Station
            {
                Code = 100360,
                Name = "Technion",
                Longitude = 35.25,
                Latitude = 32.25,
            });

            Station.Add(new Station
            {
                Code = 100370,
                Name = "Beer Sheva",
                Longitude = 35.26,
                Latitude = 32.26,
            });

            Station.Add(new Station
            {
                Code = 100380,
                Name = "Raanana",
                Longitude = 35.28,
                Latitude = 32.27,
            });

            Station.Add(new Station
            {
                Code = 100390,
                Name = "Eilat",
                Longitude = 35.29,
                Latitude = 33,
            });

            Station.Add(new Station
            {
                Code = 100400,
                Name = "Netivot",
                Longitude = 35.3,
                Latitude = 33.1,
            });

            Station.Add(new Station
            {
                Code = 100410,
                Name = "Ashdod",
                Longitude = 35.32,
                Latitude = 33.2,
            });

            Station.Add(new Station
            {
                Code = 100420,
                Name = "Bet Shemesh",
                Longitude = 35.33,
                Latitude = 33.12,
            });

            Station.Add(new Station
            {
                Code = 100430,
                Name = "Modiin",
                Longitude = 35.34,
                Latitude = 33.13,
            });

            Station.Add(new Station
            {
                Code = 100440,
                Name = "Ashkelon",
                Longitude = 35.36,
                Latitude = 33.15,
            });

            Station.Add(new Station
            {
                Code = 100450,
                Name = "Dead Sea",
                Longitude = 35.4,
                Latitude = 33.18,
            });

            Station.Add(new Station
            {
                Code = 100460,
                Name = "Ikea Rishon Letsion",
                Longitude = 35.42,
                Latitude = 33.2,
            });

            Station.Add(new Station
            {
                Code = 100470,
                Name = "Natanya",
                Longitude = 35.44,
                Latitude = 33.25,
            });

            Station.Add(new Station
            {
                Code = 100480,
                Name = "Hadera",
                Longitude = 35.46,
                Latitude = 33.27,
            });

            Station.Add(new Station
            {
                Code = 100490,
                Name = "Haifa",
                Longitude = 35.48,
                Latitude = 33.28,
            });

            Station.Add(new Station
            {
                Code = 100500,
                Name = "Mitspe Ramon",
                Longitude = 35.49,
                Latitude = 33.29,
            });

        }









        static DataSource()
        {
            InitAllLists();
        }


    




    }






    // Kerennnnn 



   













}
