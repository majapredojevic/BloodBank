using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.DataAccess.Exceptions;
using BloodBank.Data.Model;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLAccount : IAccount
    {

        private static readonly string SELECT = @"SELECT n.IdKorisnickiNalog, n.KorisnickoIme, n.Lozinka, o.IdOsoba, o.Ime, o.Prezime, z.Zvanje from korisnicki_nalog n
                                                   INNER JOIN zaposleni z on n.IdZaposleni = z.IdOsoba
                                                   INNER JOIN osoba o on z.IdOsoba = o.IdOsoba;";
      
        
        public string CheckAccount(string username, string password)
        {
            int id = GetUserId(username, password);

            string result = "";
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "vrsta_korisnika";
                cmd.Parameters.AddWithValue("@pId", id);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pVrsta", MySqlDbType.Int32);
                cmd.Parameters["@pVrsta"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = cmd.Parameters["@pVrsta"].Value.ToString();

            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAccount", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(conn);
            }
            return result;
        }



        private int GetUserId(string username, string password)
        {
            List<Account> accounts = GetAccounts();

            foreach(var a in accounts)
            { 
                if(a.UserName.Equals(username) && a.Password.Equals(password))
                {
                    return a.Employee.Person.Id;
                }

            } return -1;
        }

        public Employee GetEmployeeByUsername(string username)
        {
            List<Account> accounts = GetAccounts();

            foreach (var a in accounts)
            {
                if (a.UserName.Equals(username))
                {
                    return a.Employee;
                }

            }
            return new Employee();
        }


        public List<Account> GetAccounts()
        {
            List<Account> result = new List<Account>();
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
                    result.Add(new Account()

                    {
                        Id = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        Password = reader.GetString(2),
                        Employee = new Employee()
                        { 
                            Person = new Person()
                            {
                                Id = reader.GetInt32(3),
                                FirstName = reader.GetString(4),
                                LastName = reader.GetString(5)

                            },
                            Title = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                           
                            
                        }
                        
                    });
                }
            }
              
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlAccount", ex);
             }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
                return result;
        }


    
        
    }
}
