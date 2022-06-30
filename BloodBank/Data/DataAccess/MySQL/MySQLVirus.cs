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
    public class MySQLVirus: IVirus
    {
        private static readonly string SELECT = @"SELECT * FROM virus WHERE Naziv LIKE @str;";
        private static readonly string INSERT = @"INSERT INTO virus values (null, @Name, @ReferenceValue,@Unit);";
        private static readonly string UPDATE = @"UPDATE virus SET ReferentnaVrijednost=@ReferenceValue where IdVirus=@Id;";
        private static readonly string DELETE = @"DELETE FROM virus WHERE IdVirus=@Id";

        public List<Virus> GetViruses(string filter)
        {
            List<Virus> result = new List<Virus>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@str", "%" + filter + "%");
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Virus()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        ReferenceValue = reader.GetString(2),
                        Unit = reader.GetString(3)

                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlVirus- Select", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
        public void InsertVirus(Virus v)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Id", v.Id);
                cmd.Parameters.AddWithValue("@Name", v.Name);
                cmd.Parameters.AddWithValue("@ReferenceValue", v.ReferenceValue);
                cmd.Parameters.AddWithValue("@Unit", v.Unit);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlVirus- Insert", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }
        public void DeleteVirusById(int Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlVirus- Delete", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }

        public void UpdateVirus(Virus v)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", v.Id);
                cmd.Parameters.AddWithValue("@ReferenceValue", v.ReferenceValue);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlVirus-Update", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }

    }
}
