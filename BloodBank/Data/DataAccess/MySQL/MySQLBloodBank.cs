using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.DataAccess.Exceptions;
using BloodBank.Data.Model;
using MySql.Data.MySqlClient;

namespace BloodBank.Data.DataAccess.MySQL
{
   public  class MySQLBloodBank: IBloodBank
    {
        private static readonly string SELECT = @"SELECT IdBankaKrvi, Naziv, Email, Telefon FROM banka_info;";
        public List<Model.BloodBank> GetBloodBank()
        {
           List <Model.BloodBank> result = new List<Model.BloodBank>();
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
                    result.Add(new Model.BloodBank()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Phone = reader.GetString(3)
                    });
                }
            }


            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodBank", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
