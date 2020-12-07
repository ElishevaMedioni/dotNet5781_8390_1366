using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_03B_8390_1366
{
    public class Bus
    {
        int licenseNum;
        int kmNumGas = 0;
        int kmNumTechnicalControl = 0;
        public DateTime dateOfActivity;
        string status = null;


        public override string ToString()
        {
            string str = "Bus Number: " + licenseNumInTheGoodFormat() + "  Number of km traveled: " + GetNumTechnicalControl + "km" + "  Status: " + GetStatus + "\n";
            
            return str.ToString();
        }

        public string licenseNumInTheGoodFormat()
        {
            int numDigit = GetLicenseNum.ToString().Length;
            string myStr;
            if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                myStr = GetLicenseNum / 100000 + "-" + (GetLicenseNum % 100000) / 100 + "-" + GetLicenseNum % 100;

            else //else the licenseNum is 8 digits
                myStr = GetLicenseNum / 100000 + "-" + (GetLicenseNum % 100000) / 1000 + "-" + GetLicenseNum % 1000;
            return myStr;
        }

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
        public Bus(int myLicenseNum, DateTime mydateOfActivity, int m_kmNumGas, int m_kmNumTechnicalControl)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
            kmNumGas = m_kmNumGas;
            kmNumTechnicalControl = m_kmNumTechnicalControl;
            status = "available";
        }


        //Properties fields

        public string GetStatus
        {
            get { return status; }
            set { status = value; }
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


       
    }
}