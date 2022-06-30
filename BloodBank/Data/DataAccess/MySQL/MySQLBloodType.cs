using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.Model;
using MySql.Data.MySqlClient;
using BloodBank.Data.DataAccess.Exceptions;

namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLBloodType: IBloodType
    {
        private static readonly string SELECT = @"SELECT Naziv FROM KRVNA_GRUPA;";

        public List<BloodType> GetBloodTypes()
        {


            List<BloodType> result = new List<BloodType>();
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
                    result.Add(new BloodType()

                    {
                        Name = reader.GetString(0),

                    });
                }
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodType", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
