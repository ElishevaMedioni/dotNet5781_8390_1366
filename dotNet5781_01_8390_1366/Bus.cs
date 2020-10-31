using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_01_8390_1366
{
    class Bus
    {
        int licenseNum;
        static int kmNumGas = 0;
        static int kmNumTechnicalControl = 0;
        public DateTime dateOfActivity;
      
      

        public Bus()
        { // default constructor, initialyse
            licenseNum = 0;
            dateOfActivity = new DateTime(0, 0, 0);
        }

        public Bus(int myLicenseNum, DateTime mydateOfActivity)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
        }
        public int getLicenseNum
        {
            get { return licenseNum; }
            set { licenseNum = value; }
        }
        public int getKmNumGas
        {
            get { return kmNumGas; }
            set { kmNumGas = value; }
        }

        public int getNumTechnicalControl
        {
            get { return kmNumTechnicalControl; }
            set { kmNumTechnicalControl = value; }
        }

        public void print()
        {
            Console.WriteLine("Bus number: " + printLicenseNum() /n);
            Console.WriteLine("Number of km traveled" + kmNumGas /n);
        }


        public void printLicenseNum()
        {
            int numDigit = licenseNum.ToString().Length;

            if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                Console.WriteLine(licenseNum / 100000 + "-" + (licenseNum % 100000) / 100 + "-" + licenseNum % 100);

            else //else the licenseNum is 8 digits
                Console.WriteLine(licenseNum / 100000 + "-" + (licenseNum % 100000) / 1000 + "-" + licenseNum % 1000);
        }
        // private static void ShouldWeDoTechnicalVerification(List<Bus> buses, int km, int licenseNumInt)
        //{
        //    foreach (Bus element in buses)
        //    {


        //        if (element.getLicenseNum() == licenseNumInt)
        //        {




        //            if (kmNumGas+km > 1200)
        //            {
        //                Console.WriteLine("ERROR YOU NEED TO PUT OIL");

        //            }
        //            if (kmNumTechnicalControl+km > 20000)
        //            {
        //                Console.WriteLine("YOU NEED TO DO TECHNICAL VARIFICATION");

        //            }
        //            else
        //            {
        //                kmNumTechnicalControl += km;
        //                kmNumGas += km;
        //                Console.WriteLine("THE NEW TRIP OF BUS {1} HAS BEEN UPDATED SUCCESSFULLY", licenseNumInt);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("AUTOBUS NOT FOUND");
        //        }

        //    }

        //}
    }
}