using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace dotNet5781_03B_8390_1366
{
    public class Bus
    {
        int licenseNum;
        int kmNumGas = 0;
        int kmNumTechnicalControl = 0;
        DateTime dateOfActivity;
        DateTime dateOfTheLastTechnicalControl;
        string status = null;


        public override string ToString()
        {
            
            string str = "◎ Bus Number: " + LicenseNumInTheGoodFormat() + " \n◎ Number of km traveled: "
                + GetNumTechnicalControl + "km" + " \n◎ Status: " + Status 
                + "\n◎ Date Of Activity: " + DateOfActivity.ToShortDateString() + "\n◎ Date Of The Last Technical Control: "
                + DateOfTheLastTechnicalControl.ToShortDateString() +
                "\n";
            
            return str.ToString();
        }

        public string LicenseNumInTheGoodFormat()
        {
            int numDigit = LicenseNum.ToString().Length;
            string myStr;
            if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                myStr = LicenseNum / 100000 + "-" + (LicenseNum % 100000) / 100 + "-" + LicenseNum % 100;

            else //else the licenseNum is 8 digits
                myStr = LicenseNum / 100000 + "-" + (LicenseNum % 100000) / 1000 + "-" + LicenseNum % 1000;
            return myStr;
        }

        public Bus()
        { // default constructor, initialyse
            licenseNum = 0;
            kmNumGas = 0;
            kmNumTechnicalControl = 0;
            dateOfActivity = new DateTime(0, 0, 0);
            dateOfTheLastTechnicalControl = new DateTime(0, 0, 0);
        }

        //Parameterized Constructor
        public Bus(int myLicenseNum, DateTime mydateOfActivity)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
            dateOfTheLastTechnicalControl = mydateOfActivity;
        }
        public Bus(int myLicenseNum, DateTime mydateOfActivity, int m_kmNumGas, int m_kmNumTechnicalControl)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
            dateOfTheLastTechnicalControl = mydateOfActivity;
            kmNumGas = m_kmNumGas;
            kmNumTechnicalControl = m_kmNumTechnicalControl;
            status = "available";
        }


        //Properties fields

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int LicenseNum
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

        public DateTime DateOfActivity
        {
            get { return dateOfActivity; }
            set { dateOfActivity = value; }
        }

        public DateTime DateOfTheLastTechnicalControl
        {
            get { return dateOfTheLastTechnicalControl; }
            set { dateOfTheLastTechnicalControl = value; }
        }


    }
}
