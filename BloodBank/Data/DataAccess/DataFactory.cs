using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BloodBank.Data.DataAccess
{
    public abstract class DataFactory
    {
       public abstract IAccount Accounts { get; }
        public abstract IBloodBank BloodBank { get; }
        public abstract IOffice Offices { get; }
        public abstract IRHFactor RHFactor { get; }
        public abstract IBloodType BloodType { get; }
        public abstract IBloodParameter BloodParameter { get; }
        public abstract IBloodDonor BloodDonor { get; }
        public abstract IEmployee Employee { get; }
        public abstract IBloodDonation BloodDonation { get; }
        public abstract IVirus Virus { get; }
        public abstract IReport Report { get; }

        public static DataFactory GetMySQLDataFactory()
        {
            return new MySQL.MySQLDataFactory();
        }
    }
}
