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


    }
}
