using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace dotNet5781_03B_8390_1366
{
    class Program
    {

        public enum MyEnum { addBus, programTravel, busSetting, display, exit };

        /// <summary>
        /// A fonction to print the menu with the different options
        /// </summary>
        static public void PrintMenuOption()
        {
            Console.WriteLine("Enter your choice\n");
            Console.WriteLine("Enter 0 to add bus to the system\n");
            Console.WriteLine("Enter 1 to program a travel\n");
            Console.WriteLine("Enter 2 to fill up or carry out a technical check\n");
            Console.WriteLine("Enter 3 to display the lenghth of the travel (km)\n");
            Console.WriteLine("Enter 4 to exit\n");
        }

        static public void InitializeBus(List<Bus> buses)
        {
            DateTime date1 = new DateTime(1993, 06, 01);
            DateTime date2 = new DateTime(2019, 06, 02);
            DateTime date3 = new DateTime(2020, 7, 03);
            DateTime date4 = new DateTime(2020, 8, 04);
            DateTime date5 = new DateTime(2020, 9, 05);
            DateTime date6 = new DateTime(2020, 10, 06);
            DateTime date7 = new DateTime(2020, 11, 07);
            DateTime date8 = new DateTime(2020, 5, 08);
            DateTime date9 = new DateTime(2020, 4, 09);
            DateTime date10 = new DateTime(2020, 3, 10);

            Bus bus1 = new Bus(33333333, date2, 1190, 1000);
            Bus bus2 = new Bus(22222222, date3, 888, 19990);
            Bus bus3 = new Bus(1111111, date1, 888, 9990);
            Bus bus4 = new Bus(44444444, date4, 111, 1111);
            Bus bus5 = new Bus(55555555, date5, 1234, 12345);
            Bus bus6 = new Bus(66666666, date6, 1990, 10456);
            Bus bus7 = new Bus(77777777, date7, 1098, 9670);
            Bus bus8 = new Bus(88888888, date8, 1678, 17563);
            Bus bus9 = new Bus(99999999, date9, 234, 8976);
            Bus bus10 = new Bus(1234567, date10, 987, 99);

            buses.Add(bus1);
            buses.Add(bus2);
            buses.Add(bus3);
            buses.Add(bus4);
            buses.Add(bus5);
            buses.Add(bus6);
            buses.Add(bus7);
            buses.Add(bus8);
            buses.Add(bus9);
            buses.Add(bus10);



        }

        /// <summary>
        /// function to check if the license number that the user enter isn't already use to an other bus in the system
        /// </summary>
        /// <param name="buses"></param>
        /// <param name="myLicenseNum"></param>
        /// <returns>bool</returns>

        static public bool ExistBus(List<Bus> buses, int myLicenseNum)
        {
            return buses.Exists(x => x.GetLicenseNum == myLicenseNum);
        }





        /// <summary>
        /// a function that print all the list of the bus
        /// </summary>
        /// <param name="buses"></param>

        static public void Print(List<Bus> buses)
        {
            if (buses.Count == 0)
                Console.WriteLine("THERE IS NO BUS IN THE SYSTEM... TAP 0 TO ADD BUSES \n");
            else
            {
                foreach (Bus element in buses)
                {
                    Console.WriteLine("Bus number: ");
                    int numDigit = element.GetLicenseNum.ToString().Length;

                    if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                        Console.WriteLine(element.GetLicenseNum / 100000 + "-" + (element.GetLicenseNum % 100000) / 100 + "-" + element.GetLicenseNum % 100);

                    else //else the licenseNum is 8 digits
                        Console.WriteLine(element.GetLicenseNum / 100000 + "-" + (element.GetLicenseNum % 100000) / 1000 + "-" + element.GetLicenseNum % 1000);

                    Console.WriteLine("Number of km traveled: " + element.GetNumTechnicalControl + "km");
                    Console.WriteLine("Status: " + element.GetStatus + "\n");


                }
            }
        }





        /// <summary>
        /// function that adds buses to the system (to the list)
        /// it receives the date and the license number
        /// </summary>
        /// <returns>Bus</returns>


        static public Bus FuncAddBus(List<Bus> buses)
        {
            Console.WriteLine("Enter the date of the beginning of the bus activity: \n " +
                "Enter the day: ");
            string day = Console.ReadLine();
            int dayInt;
            int.TryParse(day, out dayInt);

            Console.WriteLine("\n Enter the month: ");
            string month = Console.ReadLine();
            int monthInt;
            int.TryParse(month, out monthInt);

            Console.WriteLine("\n Enter the year: ");
            string year = Console.ReadLine();
            int yearInt;
            int.TryParse(year, out yearInt);

            DateTime date1 = new DateTime(yearInt, monthInt, dayInt);


            Console.WriteLine("\n Enter the license number: ");
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

                Bus b2 = new Bus(licenseNumInt, date1);
                return b2;
            }
            else
            { //if the license number format is wrong

                return null;
            }
        }




        /// <summary>
        /// function to random a number
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>a random number</returns>
        static private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }





        /// <summary>
        /// function to do the technical control
        /// </summary>
        /// <param name="buses"></param>
        /// <param name="license"></param>
        static public void DoTechnicalControl(List<Bus> buses, int license)
        {
            foreach (Bus element in buses)
            {
                if (license == element.GetLicenseNum)

                {
                    if (element.GetNumTechnicalControl > 20000)
                    {
                        element.GetNumTechnicalControl = 0;
                    }

                    else
                        element.dateOfActivity = DateTime.Now;

                    Console.WriteLine($"WAIT.....  TECHNICAL CONTROL DONE\n");

                }



            }
        }



        /// <summary>
        /// function to fill the bus
        /// </summary>
        /// <param name="buses"></param>
        /// <param name="license"></param>
        static private void FillTheBus(List<Bus> buses, int license)
        {
            foreach (Bus element in buses)
            {
                if (license == element.GetLicenseNum)
                {

                    element.GetKmNumGas = 0;
                    Console.WriteLine($"WAIT.....  PETROL TANK IS FULL\n");

                }
            }
        }



        /// <summary>
        /// function to check if we can program a new travel for the bus
        /// </summary>
        /// <param name="buses"></param>
        /// <param name="km"></param>
        /// <param name="licenseNumInt"></param>
        private static void ShouldWeDoTechnicalVerification(List<Bus> buses, int km, int licenseNumInt)
        {
            foreach (Bus element in buses)
            {
                if (licenseNumInt == element.GetLicenseNum)
                {


                    DateTime date1 = DateTime.Now;
                    DateTime date2 = element.dateOfActivity;
                    TimeSpan t = date1 - date2;




                    if (element.GetKmNumGas + km > 1200)
                    {
                        Console.WriteLine("ERROR YOU NEED TO FILL OIL \n");
                        element.GetStatus = "On refueling";

                        break;
                    }


                    else if ((element.GetNumTechnicalControl + km > 20000) | Math.Round(t.TotalDays) > 375)
                    {
                        Console.WriteLine("YOU NEED TO DO TECHNICAL VERIFICATION \n");
                        element.GetStatus = "in traitement";
                        break;

                    }

                    if (element.GetKmNumGas + km > 1200 && element.GetNumTechnicalControl + km > 20000)
                        element.GetStatus = "in traitement";

                    else
                    {
                        element.GetStatus = "On the road again";
                        element.GetNumTechnicalControl += km;
                        element.GetKmNumGas += km;
                        Console.WriteLine($"THE NEW ITINERARY OF THE BUS HAS BEEN UPDATED SUCCESSFULLY FOR ");
                        Console.WriteLine(km + $" kms");

                        break;

                    }
                }
            }



        }







        static void Main18(string[] args)
        {
            List<Bus> buses = new List<Bus>(); //create a new object list 
            int choice;
            InitializeBus(buses);

            PrintMenuOption();
            do
            {

                string str = Console.ReadLine();
                int.TryParse(str, out choice);




                switch (choice)
                {
                    case 0: //add bus to the system
                        Bus b1 = FuncAddBus(buses);
                        if (b1 == null)
                            Console.WriteLine("ERROR THE LICENSE NUMBER YOU ENTERED IS WRONG\n");
                        else
                            buses.Add(b1);
                        Console.WriteLine("\n");
                        break;




                    case 1:// I ask the user the license number of the bus :



                        Console.WriteLine("PLEASE, ENTER YOUR LICENSE NUMBER :\n ");
                        string licenseNum = Console.ReadLine();
                        int licenseNumInt;
                        int.TryParse(licenseNum, out licenseNumInt);


                        if (ExistBus(buses, licenseNumInt))// I check if license exists 

                        {
                            //I RANDOM THE NUM OF KMS:
                            int kilometres = RandomNumber(5, 1200);


                            // this function checks if the license number exists, if the oil rate is
                            //not exceeded and if the rate for technical verification has not been exceeded
                            ShouldWeDoTechnicalVerification(buses, kilometres, licenseNumInt);
                        }
                        else // if license doesn't exist
                            Console.WriteLine("AUTOBUS NOT FOUND");

                        break;






                    case 2:

                        // I ask to the user his license number :
                        Console.WriteLine("PLEASE, ENTER YOUR LICENSE NUMBER \n");
                        string license = Console.ReadLine();
                        int licenseInt;
                        int.TryParse(license, out licenseInt);



                        if (ExistBus(buses, licenseInt))// I check if license exists 
                        {// if yes

                            Console.WriteLine("enter your choice\n");
                            Console.WriteLine("Enter 0 to refuel");
                            Console.WriteLine("Enter 1 to pass the technical examination\n");
                            string choiice = Console.ReadLine();
                            int choiiceInt;
                            int.TryParse(choiice, out choiiceInt);




                            switch (choiiceInt)
                            {
                                case 0: //if the user want to fill
                                    FillTheBus(buses, licenseInt);
                                    break;

                                case 1:// if user want to do technical control
                                    DoTechnicalControl(buses, licenseInt);
                                    break;

                                default:
                                    Console.WriteLine("\n SORRY, THERE IS NO SUCH OPTION \n");
                                    break;




                            }
                        }
                        else // if license doesn't exist
                            Console.WriteLine("AUTOBUS NOT FOUND");


                        break;


                    case 3: // Print 
                        Print(buses);
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