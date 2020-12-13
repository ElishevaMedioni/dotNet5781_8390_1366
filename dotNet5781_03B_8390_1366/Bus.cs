using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace dotNet5781_03B_8390_1366
{
    public class Bus : INotifyPropertyChanged
    
    {
        int licenseNum;
        string licenseNumStr;
        int kmNumGas = 0;
        int kmNumTechnicalControl = 0;
        int kmTravelled = 0;
        DateTime dateOfActivity;
        DateTime dateOfTheLastTechnicalControl;
        string status = null;
        int gasolineLevel;
        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {

            string str = "◎ Bus Number: " + licenseNumStr + " \n◎ Number of km traveled: "
                + GetNumTechnicalControl + "km" 
                + " \n◎ Status: " + Status
                + "\n◎ Date Of Activity: " + DateOfActivity.ToShortDateString() + "\n◎ Date Of The Last Technical Control: "
                + DateOfTheLastTechnicalControl.ToShortDateString() + "\n◎ " + kmNumTechnicalControl + " km traveled since the last technical control"
                + "\n◎ " + kmNumGas + " km traveled since the last refuel" + "\n◎ Gasoline's level: " + GasolineLevel + "%" +
                "\n";
            
            return str.ToString();
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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

        public string LicenseNumInTheGoodFormat(int myLicenseNum)
        {
            int numDigit = myLicenseNum.ToString().Length;
            string myStr;
            if (numDigit == 7) //if the beginning of the activity is before 2018 then the licenseNum is 7 digits
                myStr = myLicenseNum / 100000 + "-" + (myLicenseNum % 100000) / 100 + "-" + myLicenseNum % 100;

            else //else the licenseNum is 8 digits
                myStr = myLicenseNum / 100000 + "-" + (myLicenseNum % 100000) / 1000 + "-" + myLicenseNum % 1000;
            return myStr;
        }

        public Bus()
        { // default constructor, initialyse
            licenseNum = 0;
            kmNumGas = 0;
            kmNumTechnicalControl = 0;
            dateOfActivity = new DateTime(0, 0, 0);
            dateOfTheLastTechnicalControl = new DateTime(0, 0, 0);
            gasolineLevel = 100;
        }

        //Parameterized Constructor
        public Bus(int myLicenseNum, DateTime mydateOfActivity)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
            dateOfTheLastTechnicalControl = mydateOfActivity;
            licenseNumStr = LicenseNumInTheGoodFormat(licenseNum);
            gasolineLevel = 100;
        }
        public Bus(int myLicenseNum, DateTime mydateOfActivity, int m_kmNumGas, int m_kmNumTechnicalControl)
        {
            licenseNum = myLicenseNum;
            dateOfActivity = mydateOfActivity;
            dateOfTheLastTechnicalControl = mydateOfActivity;
            kmNumGas = m_kmNumGas;
            kmNumTechnicalControl = m_kmNumTechnicalControl;
            status = "Available";
            licenseNumStr = LicenseNumInTheGoodFormat(licenseNum);
            if (m_kmNumGas >= 1200)
                gasolineLevel = 0;
            else
                gasolineLevel = ((1200 - m_kmNumGas) * 100) / 1200;

        }



        //Properties fields

        public string Status
        {
            get { return status; }
            set { status = value;
                OnPropertyChanged("Status");
            }
        }

        public int LicenseNum
        {
            get { return licenseNum; }
            set { licenseNum = value; }
        }

        public string LicenseNumStr
        {
            get { return licenseNumStr; }
            set { licenseNumStr = value; }
        }

        public int GasolineLevel
        {
            get { return gasolineLevel; }
            set { gasolineLevel = value;
                OnPropertyChanged("GasolineLevel");
            }
        }

        public int GetKmNumGas
        {
            get { return kmNumGas; }
            set { kmNumGas = value;
                OnPropertyChanged("GetKmNumGas");
            }
        }

           public int GetKmTravelled
        {
            get { return kmTravelled; }
            set { kmTravelled = value; }
        }

        public int GetNumTechnicalControl
        {
            get { return kmNumTechnicalControl; }
            set { 
                kmNumTechnicalControl = value;
                OnPropertyChanged("GetNumTechnicalControl");
                    }
            
        }

        public DateTime DateOfActivity
        {
            get { return dateOfActivity; }
            set { dateOfActivity = value; }
        }

        public DateTime DateOfTheLastTechnicalControl
        {
            get { return dateOfTheLastTechnicalControl; }
            set { dateOfTheLastTechnicalControl = value;
                OnPropertyChanged("DateOfTheLastTechnicalControl");
            }
        }


    }
}
