using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_8390_1366
{
    class Program
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
            int choice;
            PrintMenuOption();
            do
            {
                choice = returnChoice();
                
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Enter 0 to add bus\n");
                        Console.WriteLine("Enter 1 to add bus station\n");
                        int choice2 = returnChoice();
                        switch (choice2)
                        {
                            case 0:
                                Console.WriteLine();
                                //func add bus
                                break;

                            case 1:
                                //func add station
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
                                Console.WriteLine();
                                //func delete bus
                                break;

                            case 1:
                                //func to delete bus station during a trip
                                break;

                            default:
                                Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter 0 to search a bus that arrive in your station \n");
                        Console.WriteLine("Enter 1 to search the best trip\n");
                        int choice4 = returnChoice();
                        switch (choice4)
                        {
                            case 0:
                                Console.WriteLine();
                                
                                break;

                            case 1:
                                
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
                                Console.WriteLine();
                                //func to print all the bus lines (par rapport au trip le + court)
                                break;

                            case 1:
                                //func to print all bus station 
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
        }
    }
}


/*
donnee a rentree dans les list  





 */