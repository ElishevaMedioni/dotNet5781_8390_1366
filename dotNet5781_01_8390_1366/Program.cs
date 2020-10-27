using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_01_8390_1366
{
        class Program
        {
            public enum MyEnum { addBus, programTravel, busSetting, display, exit };
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


                try { 
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
            }
                catch (...)
                {
                    Console.WriteLine("ERROR");
                 Console.WriteLine();
                }



            }


            static void Main(string[] args)
            {
                List<Bus> buses = new List<Bus>();
                int choice;
                while (int.TryParse(Console.ReadLine(), out choice))
                    Console.Write("ERROR, entre un autre");
                while (choice != 4)
                {
                    switch ((MyEnum)choice)
                    {
                        // // e.addBus;
                        ////  Console.WriteLine("Enter your choice");
                        //  string choice = Console.ReadLine();
                        //  int myChoice = int.Parse(choice);
                        //  switch (myChoice)

                        case MyEnum.addBus: //add bus to the system
                            funcAddBus();




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
