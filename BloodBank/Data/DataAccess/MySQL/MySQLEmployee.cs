using BloodBank.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BloodBank.Data.DataAccess.Exceptions;

namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLEmployee : IEmployee
    {
        private static readonly string SELECT_DOCTOR = @" SELECT o.IdOsoba, Ime, Prezime, z.Zvanje FROM osoba o
                                                   INNER JOIN zaposleni z ON z.IdOsoba=o.IdOsoba
                                                   INNER JOIN doktor  ON doktor.IdZaposleni=z.IdOsoba;";
        private static readonly string SELECT_LABORANT = @" SELECT o.IdOsoba, Ime, Prezime, z.Zvanje FROM osoba o
                                                   INNER JOIN zaposleni z ON z.IdOsoba=o.IdOsoba
                                                   INNER JOIN laborant  ON laborant.IdZaposleni=z.IdOsoba;";
        public List<Employee> GetDoctors()
        {
            List<Employee> result = new List<Employee>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_DOCTOR;
                reader = cmd.ExecuteReader();

               
                while (reader.Read())
                {
                    result.Add(new Employee()

                    {
                        Person = new Person()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                        },
                        Title = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                    });  

                }
                
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee-Doctor", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            
            return result;
        }


        public List<Employee> GetLaborants()
        {
            List<Employee> result = new List<Employee>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_LABORANT;
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    result.Add(new Employee()

                    {
                        Person = new Person()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                        },
                        Title = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                    });
                }
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee-Laborant", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public int GetDoctorByName(string Name)
        {
            int result = -1;
            
            var list = GetDoctors();

            foreach (var l in list)
            {
                string listName = l.Title + " " + l.Person.FirstName + " " + l.Person.LastName;
                if (listName.Equals(Name))
                    result = l.Person.Id;
              

            }
            return result;
        }



        public int GetLaborantByName(string Name)
        {
            int result = -1;
            var list = GetLaborants();
            foreach (var l in list)
            {
                string listName = l.Title + " " + l.Person.FirstName + " " + l.Person.LastName;
                if (listName.Equals(Name))
                    result = l.Person.Id;
            }
            return result;
        }
    }
}



