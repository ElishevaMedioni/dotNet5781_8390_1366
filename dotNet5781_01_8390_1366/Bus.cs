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
        int kmNumGas = 0;
        int kmNumTechnicalControl = 0;
        public DateTime dateOfActivity;



        public Bus()
        { // default constructor, initialyse
            licenseNum = 0;
            kmNumGas = 0;
            kmNumTechnicalControl = 0;
            dateOfActivity = new DateTime(0, 0, 0);
        }

        public Bus(int myLicenseNum, DateTime mydateOfActivity)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
        }
        public int GetLicenseNum
        {
            get { return licenseNum; }
            set { licenseNum = value; }
        }
        public int GetKmNumGas
        {
            get { return kmNumGas; }
            set { kmNumGas = value; }
        }

        public int GetNumTechnicalControl
        {
            get { return kmNumTechnicalControl; }
            set { kmNumTechnicalControl = value; }
        }

        /*public void print()
        {
            Console.WriteLine("Bus number: " + PrintLicenseNum());
            Console.WriteLine("Number of km traveled" + kmNumTechnicalControl);
        }


        public void PrintLicenseNum()
        {
            int numDigit = licenseNum.ToString().Length;

            if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                Console.WriteLine(licenseNum / 100000 + "-" + (licenseNum % 100000) / 100 + "-" + licenseNum % 100);

            else //else the licenseNum is 8 digits
                Console.WriteLine(licenseNum / 100000 + "-" + (licenseNum % 100000) / 1000 + "-" + licenseNum % 1000);
        }
        */
    }
}