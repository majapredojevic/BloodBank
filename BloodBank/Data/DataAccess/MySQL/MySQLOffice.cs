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
   public class MySQLOffice: IOffice
    {
        private static readonly string SELECT = @"SELECT * FROM poslovnice_info;";
        public List<Office> GetOffices()
        {
            List<Office> result = new List<Office>();
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
                    result.Add(new Office()

                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Address= new Address()
                        {  
                            Id = reader.GetInt32(4),
                            State = reader.GetString(5),
                            City = reader.GetString(6),
                            PostalCode = reader.GetString(7),
                            Street = reader.GetString(8),
                            StreetNumber = reader.GetString(9)
                        },
                        Bank = new Model.BloodBank()
                        {
                            Id = reader.GetInt32(10),
                            Name = reader.GetString(11),
                            Email = reader.GetString(12),
                            Phone = reader.GetString(11),
                        }

                    });
                }
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlOffice", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public int GetOfficeByName(string Name)
        {
            int result = -1;
            var list = GetOffices();
            foreach (var l in list)
            {
                string listName = l.Name;
                if (listName.Equals(Name))
                    result = l.Id;
            }
            return result;
        }




    }
}


