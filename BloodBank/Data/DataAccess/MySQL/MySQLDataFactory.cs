using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.DataAccess.Exceptions;
using BloodBank.Data.DataAccess.MySQL;



namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLDataFactory : DataFactory

    {
        private MySQLAccount mySQLAccount;
        private MySQLBloodBank mySQLBloodBank;
        private MySQLOffice mySQLOffice;
        private MySQLRHFactor mySQLRHFactor;
        private MySQLBloodType mySQLBloodType;
        private MySQLBloodParameter mySQLBloodParameter;
        private MySQLBloodDonor mySQLBloodDonor;
        private MySQLEmployee mySQLEmployee;
        private MySQLBloodDonation mySQLBloodDonation;
        private MySQLVirus mySQLVirus;
        private MySQLReport mySQLReport;


        public override IAccount Accounts
        {
            get
            {
                if (mySQLAccount == null)
                {
                    mySQLAccount = new MySQLAccount();
                }
                return mySQLAccount;
            }
        }

        public override IBloodBank BloodBank
        {
            get
            {
                if (mySQLBloodBank == null)
                {
                    mySQLBloodBank = new MySQLBloodBank();
                }
                return mySQLBloodBank;
            }
        }

        public override IOffice Offices
        {
            get
            {
                if (mySQLOffice == null)
                {
                    mySQLOffice = new MySQLOffice();
                }
                return mySQLOffice;
            }
        }


        public override IRHFactor RHFactor 
        {
            get
            {
                if (mySQLRHFactor == null)
                {
                    mySQLRHFactor = new MySQLRHFactor();
                }
                return mySQLRHFactor;
            }
        }

        public override IBloodType BloodType
        {
            get
            {
                if (mySQLBloodType == null)
                {
                    mySQLBloodType = new MySQLBloodType();
                }
                return mySQLBloodType;
            }
        }


        public override IBloodParameter BloodParameter 
        {
            get
            {
                if (mySQLBloodParameter == null)
                {
                    mySQLBloodParameter = new MySQLBloodParameter();
                }
                return mySQLBloodParameter;
            }
        }

        public override IBloodDonor BloodDonor
        {
            get
            {
                if (mySQLBloodDonor == null)
                {
                    mySQLBloodDonor = new MySQLBloodDonor();

                }
                return mySQLBloodDonor;
            }
           
        }

        public override IEmployee Employee
        {
            get
            {
                if (mySQLEmployee == null)
                {
                    mySQLEmployee = new MySQLEmployee();
                }
                return mySQLEmployee;
            }
        }


        public override IBloodDonation BloodDonation
        {
            get
            {
                if (mySQLBloodDonation == null)
                {
                    mySQLBloodDonation = new MySQLBloodDonation();

                }
                return mySQLBloodDonation;
            }

        }

        public override IVirus Virus
        {
            get
            {
                if (mySQLVirus == null)
                {
                    mySQLVirus = new MySQLVirus();
                }
                return mySQLVirus;
            }
        }

        public override IReport Report
        {
            get
            {
                if(mySQLReport == null)
                {
                    mySQLReport = new MySQLReport();
                }
                return mySQLReport;
            }
        }

    }
}
