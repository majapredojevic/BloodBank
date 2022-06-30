using BloodBank.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using BloodBank.Data.DataAccess.Exceptions;

namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLRHFactor : IRHFactor
    {
        private static readonly string SELECT = @"SELECT Naziv FROM RH_FAKTOR;";

        public  List<RHFactor> GetRHFactors()
        {


            List<RHFactor> result = new List<RHFactor>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    result.Add(new RHFactor()

                    {
                        Name = reader.GetString(0),
                       
                    });
                }
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlRHFactor", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }


    

      
       
    }
}
