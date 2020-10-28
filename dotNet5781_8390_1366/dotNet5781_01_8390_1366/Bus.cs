using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_01_8390_1366
{
    class Bus
    {
        private int licenseNum;
        private static int kmNumGas = 0;
        private static int kmNumTechnicalControl = 0;
        DateTime dateOfActivity;

        public Bus() { // default constructor, initialyse
            licenseNum = 0;
            dateOfActivity  = new DateTime(0, 0, 0);
        }

        public Bus(int myLicenseNum, DateTime mydateOfActivity)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
        }

        public int getLicenseNum()
        {
            return licenseNum;
        }

        public void printLicenseNum()
        {
            int numDigit = licenseNum.ToString().Length;

            if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                Console.WriteLine(licenseNum/100000 + "-" + (licenseNum%100000)/100 + "-" + licenseNum % 100);

            else //else the licenseNum is 8 digits
                Console.WriteLine(licenseNum / 100000 + "-" + (licenseNum % 100000) / 1000 + "-" + licenseNum % 1000);
        }
    }
}
