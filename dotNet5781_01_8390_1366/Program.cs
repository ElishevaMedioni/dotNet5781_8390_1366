using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dotNet5781_01_8390_1366
{
    class Program
    {
        
        public enum MyEnum { addBus, programTravel, busSetting, display, exit };

        /// <summary>
        /// A fonction to print the menu with the different options
        /// </summary>
        static public void PrintMenuOption()
        {
            Console.WriteLine("enter your choice/n");
            Console.WriteLine("Enter 0 to add bus to the system/n");
            Console.WriteLine("Enter 1 to program a travel/n" );
            Console.WriteLine("Enter 2 to fil up or carry out a technical check/n");
            Console.WriteLine("Enter 3 to  display the km traveld/n" );
            Console.WriteLine("Enter 4 to exit, bye bye/n" );
        }

        
        /// <summary>
        /// fonction to check if the license number that the user enter isn't already use to an other bus in  the system
        /// </summary>
        /// <param name="buses"></param>
        /// <param name="myLicenseNum"></param>
        /// <returns>bool</returns>
        static public bool ExistBus(List<Bus> buses, int myLicenseNum)
        {
            return buses.Exists(x => x.GetLicenseNum == myLicenseNum);
        }

        static public void Print(List<Bus> buses)
        {
            foreach (Bus element in buses)
            {
                Console.WriteLine("Bus number: ");
                int numDigit = element.GetLicenseNum.ToString().Length;

                if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                    Console.WriteLine(element.GetLicenseNum / 100000 + "-" + (element.GetLicenseNum % 100000) / 100 + "-" + element.GetLicenseNum % 100);

                else //else the licenseNum is 8 digits
                    Console.WriteLine(element.GetLicenseNum / 100000 + "-" + (element.GetLicenseNum % 100000) / 1000 + "-" + element.GetLicenseNum % 1000);
                PrintLicenseNum();
                Console.WriteLine("/n Number of km traveled" + element.GetNumTechnicalControl + "/n");
            }
        }


        static public void PrintLicenseNum()
        {
           
        }

        /// <summary>
        /// function that adds buses to the system (to the list)
        /// it receives the date and the license number
        /// </summary>
        /// <returns>Bus</returns>
        static public Bus FuncAddBus(List<Bus> buses)
        {
            Console.WriteLine("Enter date of the beginning of your activity: /n " +
                "Enter the day ");
            string day = Console.ReadLine();
            int dayInt;
            int.TryParse(day, out  dayInt);

            Console.WriteLine("/n Enter the month: ");
            string month = Console.ReadLine();
            int monthInt;
            int.TryParse(month, out monthInt);

            Console.WriteLine("/n Enter the year: ");
            string year = Console.ReadLine();
            int yearInt;
            int.TryParse(year, out yearInt);

            DateTime date1 = new DateTime(yearInt, monthInt, dayInt);


            Console.WriteLine("Enter your license number: ");
            string licenseNum = Console.ReadLine();
            int licenseNumInt;
            int.TryParse(licenseNum, out licenseNumInt);
            if (ExistBus(buses, licenseNumInt)) ///trouver solution pour quil reconnaisse la list 
                return null;
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
            else
            { //if the license number format is wrong

                return null;
            }
        }

        // KEREN
        //FONCTION QUI PERMER DE TROUVER LE NOMBRE DE KMS EN RANDOM 
        static private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static private void DoTechnicalControl(List<Bus> buses, int license)
        {
            foreach (Bus element in buses)
            {
                if (element.GetLicenseNum == license)
                {
                    element.GetNumTechnicalControl = 0;
                    Console.WriteLine($"WAIT.....  TECHNICAL CONTROL DONE");
                }
            }
        }
        static private void FillTheBus(List<Bus> buses, int license)
        {
            foreach (Bus element in buses)
            {
                if (element.GetLicenseNum == license)
                {
                    element.GetKmNumGas = 0;
                    Console.WriteLine($"WAIT.....  FULL");
                }
            }
        }

        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();
            int choice;
            PrintMenuOption();

            while (int.TryParse(Console.ReadLine(), out choice))
                Console.Write("ERROR, entre un autre");
            while (choice != 4)
            {
                switch ((MyEnum)choice)
                {
                    case MyEnum.addBus: //add bus to the system
                        if (FuncAddBus(buses) == null)
                        {
                            Console.WriteLine("ERROR the license number you entered is wrong/n");
                        }
                        else
                        {
                            Bus b1 = FuncAddBus(buses);
                            buses.Add(b1);
                        }
                        break;




                    case MyEnum.programTravel:


                        // je demande a l'utilisateur son numero de licence :
                        Console.WriteLine("Enter your license number: ");
                        string licenseNum = Console.ReadLine();
                        int licenseNumInt;
                        int.TryParse(licenseNum, out licenseNumInt);



                        //je random le numero de kms d'un trajet :
                        int kilometres = RandomNumber(5, 1200);
                        // fonction suivante verifier : si la license existe, si le taux oil n'est pas depasser, si le taux pour verification technique na pas ete depasser
                        ShouldWeDoTechnicalVerification(buses, kilometres, licenseNumInt);

                        break;






                    case MyEnum.busSetting:
                        Console.WriteLine("enter your choice/n");
                        Console.WriteLine("Enter 0 to refuel/n");
                        Console.WriteLine("Enter 1 to pass the technical examination/n");
                        string choiice = Console.ReadLine();
                        int choiiceInt;
                        int.TryParse(choiice, out choiiceInt);



                        // je demande a l'utilisateur son numero de licence :
                        Console.WriteLine("Enter your license number: ");
                        string license = Console.ReadLine();
                        int licenseInt;
                        int.TryParse(license, out licenseInt);
                      
                        
                        
                        switch(choiiceInt)
                        {
                            case 0:
                                FillTheBus(buses, licenseInt);
                                break;

                            case 1:
                                DoTechnicalControl(buses, licenseInt);
                                break;

                            default:
                                break;




                        }


                        break;


                    case MyEnum.display:
                        Print(buses);
                        break;
                   
                    default:
                        Console.WriteLine("no such option");
                        break;
                }
                PrintMenuOption();
                
            }
        }

        private static void ShouldWeDoTechnicalVerification(List<Bus> buses, int km, int licenseNumInt)
        {
            foreach (Bus element in buses)
            {
                DateTime date1 = DateTime.Now;
                DateTime date2 = element.dateOfActivity;
                TimeSpan t = date1 - date2;



                if (element.GetLicenseNum == licenseNumInt)
                {
                    if (element.GetKmNumGas + km > 1200)
                    {
                        Console.WriteLine("ERROR YOU NEED TO PUT OIL");

                    }


                    if (element.GetNumTechnicalControl + km > 20000)
                    {
                        Console.WriteLine("YOU NEED TO DO TECHNICAL VARIFICATION");
                    }

                    if (Math.Round(t.TotalDays) > 375)
                    {
                        Console.WriteLine("YOU NEED TO DO TECHNICAL VARIFICATION");
                    }


                    else
                    {
                        element.GetNumTechnicalControl += km;
                        element.GetKmNumGas += km;
                        Console.WriteLine("THE NEW TRIP OF BUS {1} HAS BEEN UPDATED SUCCESSFULLY", licenseNumInt);
                    }
                }
                else
                {
                    Console.WriteLine("AUTOBUS NOT FOUND");
                }

            }
            Console.ReadKey();
        }
        
    }
    
   
}
