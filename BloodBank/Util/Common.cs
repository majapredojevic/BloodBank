using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BloodBank.Data.DataAccess;

namespace BloodBank.Util
{
    public static class Common
    {
        private static DataFactory dataFactory;
        public static DataFactory DataFactory
        {
            get
            {
                if (dataFactory == null)
                {
                    string bloodBankFactory = ConfigurationManager.AppSettings["BloodBankFactory"];
                    if ("MySql".Equals(bloodBankFactory))
                    {
                        dataFactory = DataFactory.GetMySQLDataFactory();
                    }
                }
                return dataFactory;
            }
        }
    }
}

