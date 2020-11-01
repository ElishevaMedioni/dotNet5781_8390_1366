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

        //Parameterized Constructor
        public Bus(int myLicenseNum, DateTime mydateOfActivity)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
        }

        //Properties fields
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
    }
}