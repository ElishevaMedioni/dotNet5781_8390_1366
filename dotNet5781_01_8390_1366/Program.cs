using System;
using System.Collections.Generic;

namespace dotNet5781_01_8390_1366
{
    class Program
    {
        public enum MyEnum { addBus, programTravel, busSetting, display, exit };

        /// <summary>
        /// A fonction to print the menu with the different options
        /// </summary>
        static public void printMenuOption()
        {
            Console.WriteLine("enter your choice/n");
            Console.WriteLine("Enter 0 to add bus to the system/n");
            Console.WriteLine("Enter 1 to program a travel/n");
            Console.WriteLine("Enter 2 to fil up or carry out a technical check/n");
            Console.WriteLine("Enter 3 to  display the km traveld/n");
            Console.WriteLine("Enter 4 to exit, bye bye/n");
        }

        /// <summary>
        /// fonction to check if the license number that the user enter isn't already use to an other bus in  the system
        /// </summary>
        /// <param name="buses"></param>
        /// <param name="myLicenseNum"></param>
        /// <returns>bool</returns>
        static public bool ExistBus(List<Bus> buses, int myLicenseNum)
        {
            return buses.Exists(x => x.getLicenseNum() == myLicenseNum);
        }


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

        //KEREN
        //FONCTION QUI PERMET DE CALCULER ESSENCE QUI RESTE 

     
      
        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();
            int choice;
            printMenuOption();

            while (int.TryParse(Console.ReadLine(), out choice))
                Console.Write("ERROR, entre un autre");
            while (choice != 4)
            {
                switch ((MyEnum)choice)
                {
                    case MyEnum.addBus: //add bus to the system
                        if (funcAddBus() == null)
                        {
                            Console.WriteLine("ERROR the license number you entered is wrong/n");
                        }
                        else
                        {
                            Bus b1 = funcAddBus();
                            buses.Add(b1);
                        }
                        break;







                    case MyEnum.programTravel:

                        {
                            // je demande a l'utilisateur son numero de licence :
                            Console.WriteLine("Enter your license number: ");
                            string licenseNum = Console.ReadLine();
                            int licenseNumInt;
                            int.TryParse(licenseNum, out licenseNumInt);

                            //Je verifie si le numero de license existe:
                            // Si elle existe : 
                            if (ExistBus(buses, licenseNumInt))
                            {
                                //je random le numero de kms d'un trajet :
                                int kilometres = RandomNumber(5, 20);
                                
                                ShouldWeDoTechnicalVerification(buses, kilometres, licenseNumInt);

                              

                                // if (ShouldWePutOil())

                                //List<Bus> buses, int myLicenseNum

                            }







                            // si le numero de licence n'existe pas:
                            else Console.WriteLine("error ");


                        }







                        break;
                    case MyEnum.busSetting:
                        break;
                    case MyEnum.display:
                        break;
                    default:
                        Console.WriteLine("no such option");
                        break;
                }
                printMenuOption();
            }
        }

        /* private static void ShouldWeDoTechnicalVerification(List<Bus> buses, int kilometres, int licenseNumInt)
         {
             throw new NotImplementedException();
         }
        */
        private static void ShouldWeDoTechnicalVerification(List<Bus> buses, int km, int licenseNumInt)
        {
            foreach (Bus element in buses)
            {


                if (element.getLicenseNum() == licenseNumInt)
                {




                    if (element.getKmNumGas() + km > 1200)
                    {
                        Console.WriteLine("ERROR YOU NEED TO PUT OIL");

                    }
                    if (element.getNumTechnicalControl() + km > 20000)
                    {
                        Console.WriteLine("YOU NEED TO DO TECHNICAL VARIFICATION");

                    }
                    else
                    {
                        element.getNumTechnicalControl += km;
                        element.getKmNumGas += km;
                        Console.WriteLine("THE NEW TRIP OF BUS {1} HAS BEEN UPDATED SUCCESSFULLY", licenseNumInt);
                    }
                }
                else
                {
                    Console.WriteLine("AUTOBUS NOT FOUND");
                }

            }

        }
    }
}