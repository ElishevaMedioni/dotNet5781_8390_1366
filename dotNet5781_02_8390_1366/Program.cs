using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dotNet5781_02_8390_1366
{
    public class Program
    {
        public enum MyEnum { add, delete, search, print, exit };


        static public int returnChoice()
        {
            int choice;
            string str = Console.ReadLine();
            int.TryParse(str, out choice);
            return choice;
        }




        /// <summary>
        /// function that initialyses 40 addresses in 40 bus stations and adds them in the system
        /// And initialyses 10 buses in the system, and add stations to them
        /// </summary>
        /// <param name="lstStation"></param>
        /// <param name="lstBus"></param>
        static public void initialyseAddressAndBuses(ListOfBusStation lstStation, ListOfBusLines lstBus)
        {
            BusStation s1 = new BusStation("Yafo");
            BusStation s2 = new BusStation("King George");
            BusStation s3 = new BusStation("Central Station");
            BusStation s4 = new BusStation("Kyriat Moshe");
            BusStation s5 = new BusStation("Kikar Denia");
            BusStation s6 = new BusStation("Hakotel");
            BusStation s7 = new BusStation("Mamilla");
            BusStation s8 = new BusStation("Mahane Yehuda");
            BusStation s9 = new BusStation("Yad Vashem");
            BusStation s10 = new BusStation("Talpiot");
            BusStation s11 = new BusStation("Rehavia");
            BusStation s12 = new BusStation("Ramot");
            BusStation s13 = new BusStation("Museum Israel");
            BusStation s14 = new BusStation("Mahon Tal");
            BusStation s15 = new BusStation("Mahon Lev");
            BusStation s16 = new BusStation("Malha Mall");
            BusStation s17 = new BusStation("Jerusalem Beach");
            BusStation s18 = new BusStation("Gordon Beach");
            BusStation s19 = new BusStation("Tel Aviv Mall");
            BusStation s20 = new BusStation("Raanana");
            BusStation s21 = new BusStation("Technion");
            BusStation s22 = new BusStation("Haifa");
            BusStation s23 = new BusStation("Tiberias");
            BusStation s24 = new BusStation("Eilat");
            BusStation s25 = new BusStation("Ashdod");
            BusStation s26 = new BusStation("Ashkelon");
            BusStation s27 = new BusStation("Ramat Gan");
            BusStation s28 = new BusStation("Beer Sheva");
            BusStation s29 = new BusStation("Massada");
            BusStation s30 = new BusStation("Ein Gedi");
            BusStation s31 = new BusStation("Dead Sea");
            BusStation s32 = new BusStation("Bne Brak");
            BusStation s33 = new BusStation("Hadera");
            BusStation s34 = new BusStation("Bat Yam");
            BusStation s35 = new BusStation("Ikea Rishon Letsion");
            BusStation s36 = new BusStation("Netania");
            BusStation s37 = new BusStation("Bet Shemesh");
            BusStation s38 = new BusStation("Meron");
            BusStation s39 = new BusStation("Netivot");
            BusStation s40 = new BusStation("Mount Hermon");

            lstStation.addBusStationToTheList(s1);
            lstStation.addBusStationToTheList(s2);
            lstStation.addBusStationToTheList(s3);
            lstStation.addBusStationToTheList(s4);
            lstStation.addBusStationToTheList(s5);
            lstStation.addBusStationToTheList(s6);
            lstStation.addBusStationToTheList(s7);
            lstStation.addBusStationToTheList(s8);
            lstStation.addBusStationToTheList(s9);
            lstStation.addBusStationToTheList(s10);
            lstStation.addBusStationToTheList(s11);
            lstStation.addBusStationToTheList(s12);
            lstStation.addBusStationToTheList(s13);
            lstStation.addBusStationToTheList(s14);
            lstStation.addBusStationToTheList(s15);
            lstStation.addBusStationToTheList(s16);
            lstStation.addBusStationToTheList(s17);
            lstStation.addBusStationToTheList(s18);
            lstStation.addBusStationToTheList(s19);
            lstStation.addBusStationToTheList(s20);
            lstStation.addBusStationToTheList(s21);
            lstStation.addBusStationToTheList(s22);
            lstStation.addBusStationToTheList(s23);
            lstStation.addBusStationToTheList(s24);
            lstStation.addBusStationToTheList(s25);
            lstStation.addBusStationToTheList(s26);
            lstStation.addBusStationToTheList(s27);
            lstStation.addBusStationToTheList(s28);
            lstStation.addBusStationToTheList(s29);
            lstStation.addBusStationToTheList(s30);
            lstStation.addBusStationToTheList(s31);
            lstStation.addBusStationToTheList(s32);
            lstStation.addBusStationToTheList(s33);
            lstStation.addBusStationToTheList(s34);
            lstStation.addBusStationToTheList(s35);
            lstStation.addBusStationToTheList(s36);
            lstStation.addBusStationToTheList(s37);
            lstStation.addBusStationToTheList(s38);
            lstStation.addBusStationToTheList(s39);
            lstStation.addBusStationToTheList(s40);


            BusLine b1 = new BusLine("Jerusalem");
            b1.setTheRoute(s1, s2, s3, s4);
            b1.setTheRoute(s6, s9, s10, s13);

            BusLine b2 = new BusLine("Jerusalem");
            b2.setTheRoute(s5, s6, s7, s8);
            b2.addStationToTheEndOfATrip(s1);

            BusLine b3 = new BusLine("Jerusalem");
            b3.setTheRoute(s9, s10, s11, s12);
            b3.setTheRoute(s15, s17, s16, s23);

            BusLine b4 = new BusLine("Jerusalem");
            b4.setTheRoute(s13, s14, s15, s16);
            b4.addStationToTheEndOfATrip(s20);

            BusLine b5 = new BusLine("Center");
            b5.setTheRoute(s17, s18, s19, s20);
            b5.setTheRoute(s1, s3, s5, s6);

            BusLine b6 = new BusLine("North");
            b6.setTheRoute(s21, s22, s23, s24);

            BusLine b7 = new BusLine("Center");
            b7.setTheRoute(s25, s26, s27, s28);
            b7.setTheRoute(s34, s37, s4, s40);

            BusLine b8 = new BusLine("North");
            b8.setTheRoute(s29, s30, s31, s32);

            BusLine b9 = new BusLine("Center");
            b9.setTheRoute(s33, s34, s35, s36);

            BusLine b10 = new BusLine("South");
            b10.setTheRoute(s37, s38, s39, s40);

            lstBus.addBusLineToTheList(b1);
            lstBus.addBusLineToTheList(b2);
            lstBus.addBusLineToTheList(b3);
            lstBus.addBusLineToTheList(b4);
            lstBus.addBusLineToTheList(b5);
            lstBus.addBusLineToTheList(b6);
            lstBus.addBusLineToTheList(b7);
            lstBus.addBusLineToTheList(b8);
            lstBus.addBusLineToTheList(b9);
            lstBus.addBusLineToTheList(b10);

        }



        /// <summary>
        /// function that add a station to the route bus depending on where the user wants to add it
        /// </summary>
        /// <param name="myStation"></param>
        /// <param name="myBus"></param>
        static public void addStationInBusRoute(BusStation myStation, BusLine myBus)
        {
            Console.WriteLine("Where do you want to add your station in the route\n");
            //the user has the choice to add his new station, where he wants in the route
            Console.WriteLine("Tap 0 to add the station at the beginning of the route, 1 to the end and 2 in the middle\n ");
            int choice6 = returnChoice();
            switch (choice6)
            {
                case 0: //if the user wants to add the station at the beginning of the route
                    myBus.addStationToTheBeginningOfATrip(myStation);
                    break;
                case 1: //if the user wants to add the station at the end of the route
                    myBus.addStationToTheEndOfATrip(myStation);
                    break;
                case 2:  //if the user wants to add the station at the middle of the route
                    Console.WriteLine("TAP the station number that will follow the new station\n");
                    int nextStation = returnChoice();
                    int index = myBus.FindIndexOfAStationInTheRoute(nextStation);
                    if (index == -1)
                        Console.WriteLine("This station isn't in the route of the bus\n");
                    else
                        myBus.addStationInTheMiddleOfATrip(myStation, index);
                    break;

                default:
                    Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                    break;

            }
        }

        /// <summary>
        /// A fonction to print the menu with the different options
        /// </summary>
        static public void PrintMenuOption()
        {
            Console.WriteLine("Enter your choice\n");
            Console.WriteLine("Enter 0 to add bus or add bus station\n");
            Console.WriteLine("Enter 1 to delete bus or delete bus station during a trip\n");
            Console.WriteLine("Enter 2 to search a bus that arrive in your station or search the best trip\n");
            Console.WriteLine("Enter 3 to print all the bus lines or print all bus station\n");
            Console.WriteLine("Enter 4 to exit\n");
        }


       



        static void Main(string[] args)
        {


            ListOfBusLines lstBus = new ListOfBusLines();
            ListOfBusStation lstBusStation = new ListOfBusStation();

            initialyseAddressAndBuses(lstBusStation, lstBus);


            int choice;
            PrintMenuOption();

            do
            {
                choice = returnChoice();

                switch (choice)
                {
                    case 0:


                        Console.WriteLine("Enter 0 to add bus to the system\n");
                        Console.WriteLine("Enter 1 to add bus station to the trip\n");
                        int choice2 = returnChoice();
                        switch (choice2)
                        {
                            case 0: //add a new bus to the system
                                BusLine bus = new BusLine(); //creating a new bus (bus is a new bus)
                                Console.WriteLine("Your bus number #" + bus.GetBusLineNum + " has been added successfully :-)\n");
                                lstBus.addBusLineToTheList(bus); //adding the bus in the system
                                break;

                            case 1: //add a station to a bus route

                                Console.WriteLine("Tap the bus line to which you want to add a station to its route\n");
                                int busNum;
                                string str = Console.ReadLine();
                                int.TryParse(str, out busNum);
                                if (lstBus.ExistBus(busNum)) //checking if the bus is already in the system 
                                {
                                    BusLine bus2 = lstBus.findABusInTheList(busNum); //we find the bus in the system
                                    //bus2 is a bus that already exists in the system
                                    Console.WriteLine("Tap the station number you want to add to the route\n");
                                    int stationNum;
                                    string str2 = Console.ReadLine();
                                    int.TryParse(str2, out stationNum);
                                    if (lstBusStation.ExistStation(stationNum)) //if the station exists in the system
                                    {
                                        BusStation myStation = lstBusStation.findAStationInTheList(stationNum);

                                        if (bus2.searchStationInATrip(stationNum)) //checking if the station isn't already in the bus route
                                            Console.WriteLine("this station is already in the route\n");
                                        else
                                        {
                                            addStationInBusRoute(myStation, bus2);
                                            Console.WriteLine("Your station number " + myStation.GetBusStationKey + " has been added successfully :-)\n");
                                        }
                                    }
                                    else //if the user station wants to add a new station
                                    {
                                        Console.WriteLine("Tap an adress for your new Station\n");
                                        string str3 = Console.ReadLine();
                                        BusStation newBusStation = new BusStation(stationNum, str3); //creating new station in the system
                                        lstBusStation.addBusStationToTheList(newBusStation); //add the new station in the system

                                        addStationInBusRoute(newBusStation, bus2); //add the new station in the bus route
                                        Console.WriteLine("Your station number " + newBusStation.GetBusStationKey + " has been added successfully :-)\n");
                                    }
                                }
                                else //if the bus line isn't in the system, the user have to add a bus (tap 0)
                                {
                                    Console.WriteLine("The Bus Line you entered isn't in the system\n ");
                                    Console.WriteLine("TAP 0 and 0 in the principal menu to add a new bus\n");
                                }

                                break;

                            default:
                                Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                                break;
                        }


                        break;









                    case 1:
                        Console.WriteLine("Enter 0 to delete bus\n");
                        Console.WriteLine("Enter 1 to delete bus station during a trip\n");
                        int choice3 = returnChoice();
                        switch (choice3)
                        {
                            case 0:

                                Console.WriteLine("Tap the bus line you want to delete\n");
                                int busNum;
                                string str2 = Console.ReadLine();
                                int.TryParse(str2, out busNum);

                                lstBus.FindAndDelete(busNum);



                                break;




                            case 1:
                                Console.WriteLine("Enter the Bus Line to which you want to delete a station to its route\n");
                                int busLineNum = returnChoice();
                                if (lstBus.ExistBus(busLineNum))
                                {
                                    BusLine b1 = lstBus.findABusInTheList(busLineNum); //we find the bus in the system

                                    Console.WriteLine("Enter number of the station that you want to delete\n");
                                    int busStation;
                                    string str3 = Console.ReadLine();
                                    int.TryParse(str3, out busStation);

                                    if (lstBusStation.ExistStation(busStation))
                                    {
                                        if (b1.searchStationInATrip(busStation))
                                        {

                                            b1.deleteStationToTheTrip(busStation);
                                            lstBusStation.deleteBusStationFromTheList(busStation);

                                        }
                                        else
                                            Console.WriteLine("this station isn't in the route of bus number " + b1.GetBusLineNum + "\n");

                                    }
                                    else
                                        Console.WriteLine("This station isn't in the system");
                                }
                                else
                                    Console.WriteLine("The Bus Line you entered isn't in the system\n ");



                                break;






                            default:
                                Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                                break;
                        }

                        break;





                    case 2:
                        Console.WriteLine("Enter 0 to search a bus that arrive in your station \n");
                        Console.WriteLine("Enter 1 to search the best route\n");
                        int choice4 = returnChoice();
                        switch (choice4)
                        {
                            case 0:
                                Console.WriteLine("Tap the Station Number\n");
                                int stationNum = returnChoice();
                                if (lstBusStation.ExistStation(stationNum))
                                {
                                    BusStation myStation = lstBusStation.findAStationInTheList(stationNum);
                                    myStation.printTheBusLine();
                                    Console.WriteLine("\n");
                                }
                                else
                                {
                                    Console.WriteLine("This station isn't in the system, if you want to add station Tap 0\n");
                                }

                                break;

                            case 1:
                                Console.WriteLine("Enter the number of the first station\n");
                                int firstStation = returnChoice();
                                Console.WriteLine("Enter the number of the last station\n");
                                int lastStation = returnChoice();
                                BusStation bs1 = lstBusStation.findAStationInTheList(firstStation);
                                BusStation bs2 = lstBusStation.findAStationInTheList(lastStation);
                                List<BusLine> lstBusInCommon = new List<BusLine>();
                                lstBusInCommon = bs1.findBusesInCommon(bs2);
                                List<BusStation.DistanceAndTimeBetweenStation> lstD = new List<BusStation.DistanceAndTimeBetweenStation>();
                                foreach (BusLine element in lstBusInCommon)
                                {
                                    var d = new BusStation.DistanceAndTimeBetweenStation(element.SubRoute(firstStation, lastStation));
                                    lstD.Add(d);
                                }
                                lstD.Sort();
                                foreach (var element in lstD)
                                    element.print();
                                //for (int i = 0; i<lstD.Count; i++)
                                //{
                                //    int comparaison;
                                //    BusStation.DistanceAndTimeBetweenStation min;
                                //    comparaison = lstD[i].CompareTo(lstD[i + 1]);
                                //    if (comparaison < 0 || comparaison == 0)
                                //    {
                                //        min = lstD[i];
                                //    }
                                //    else
                                //    { 
                                //        min = lstD[i + 1];
                                      
                                //    }
                                //}
                                break;



                            default:
                                Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                                break;
                        }

                        break;

                    case 3:

                        Console.WriteLine("Enter 0 to to print all the bus lines\n");
                        Console.WriteLine("Enter 1 to print all bus station\n");
                        int choice5 = returnChoice();
                        switch (choice5)
                        {
                            case 0:
                                lstBus.printAllBuses();
                                break;

                            case 1:
                                lstBusStation.printAll();
                                break;

                            default:
                                Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                        break;

                }

                PrintMenuOption();
            }
            while (choice != 4);
            Console.ReadKey();
        }
    }

}

