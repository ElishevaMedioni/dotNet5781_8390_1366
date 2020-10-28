using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;

namespace dotNet5781_01_8390_1366
{
    class Program
    {
        public enum MyEnum { addBus, programTravel, busSetting, display, exit };

        //public bool SearchBus(List<Bus> buses, int myLicenseNum)
        //{
        //    foreach (licenseNum.buses)
        //}


        //static public ArrayList addLicenseNumToArray (ArrayList licenseNumArray, int licenseNum)
        //{
            
        //    ArrayList licenseNumArray = new ArrayList();
        //    licenseNumArray.Add(licenseNum);
        //    return licenseNumArray;

        //}
        
        //static public bool findLicenseNum(ArrayList licenseNumArray, int licenseNum)
        //{
        //    int index = licenseNumArray.BinarySearch(licenseNum);
        //    if (index == 0)
        //    {
        //        Console.WriteLine("This license number is already taken, sorry!!");
        //        return false;
        //    }
        //    else
        //    {
        //        licenseNumArray.Add(licenseNum);
        //        return true;
        //    }
                
        //}


        /// <summary>
        /// function that adds buses to the system (to the list)
        /// it receives the date and the license number
        /// </summary>
        /// <returns>Bus</returns>
        static public Bus funcAddBus() 
        {
            Console.WriteLine("Enter date of the beginning of your activity: /n " +
                "Enter the day ");
            string day = Console.ReadLine();
            int dayInt;
            int.TryParse(day, out dayInt);

            Console.WriteLine("/n Enter the month: ");
            string month = Console.ReadLine();
            int monthInt;
            int.TryParse(month, out monthInt);

            Console.WriteLine("/n Enter the year: ");
            string year = Console.ReadLine();
            int yearInt;
            int.TryParse(year, out yearInt);

            DateTime date1 = new DateTime(yearInt, monthInt, dayInt);

            
            Console.WriteLine("Enter your license number with 7 numbers: ");
            string licenseNum = Console.ReadLine();
            int licenseNumInt;
            int.TryParse(licenseNum, out licenseNumInt);
            if (yearInt < 2018 && licenseNum.Length == 7)
            {
                Bus b1 = new Bus(licenseNumInt, date1);
                return b1;
            }
            else if (yearInt > 2018 && licenseNum.Length == 8)
            {

                Bus b1 = new Bus(licenseNumInt, date1);
                return b1;
            }
            else {
                Console.WriteLine("ERROR");
                Console.WriteLine();
                return null;
            }
        }
            static void Main(string[] args)
            {
                List<Bus> buses = new List<Bus>();
            //ArrayList licenseNumArray = new ArrayList();
            int choice;
                while (int.TryParse(Console.ReadLine(), out choice))
                    Console.Write("ERROR, entre un autre");
                while (choice != 4)
                {
                    switch ((MyEnum)choice)
                    {
                        case MyEnum.addBus: //add bus to the system
                            Bus b1 = funcAddBus();
                       

                        buses.Add(b1);
                            break;

                        case MyEnum.programTravel:
                            break;
                        case MyEnum.busSetting:
                            break;
                        case MyEnum.display:
                            break;
                        default:
                            break;
                    }
                }
            }


        }
    }