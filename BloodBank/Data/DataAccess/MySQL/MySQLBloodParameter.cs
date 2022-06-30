using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BloodBank.Data.Model;
using BloodBank.Data.DataAccess.Exceptions;

namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLBloodParameter : IBloodParameter
    {
        private static readonly string SELECT = @"SELECT * FROM krvni_parametar WHERE Naziv LIKE @str;";
        private static readonly string INSERT = @"INSERT INTO krvni_parametar values (null, @Name, @ReferenceValue, @Unit);";
        private static readonly string UPDATE = @"UPDATE krvni_parametar SET ReferentnaVrijednost=@ReferenceValue where Id=@Id;";
        private static readonly string DELETE = @"DELETE FROM krvni_parametar WHERE Id=@Id;";

        public List<BloodParameter> GetBloodParameters(string filter)
        {
            List<BloodParameter> result = new List<BloodParameter>();
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
                    result.Add(new BloodParameter()
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
                throw new DataAccessException("Exception in MySqlBloodParameter- Select", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
        public void InsertBloodParameter(BloodParameter bp)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Id", bp.Id);
                cmd.Parameters.AddWithValue("@Name", bp.Name);
                cmd.Parameters.AddWithValue("@ReferenceValue", bp.ReferenceValue);
                cmd.Parameters.AddWithValue("@Unit", bp.Unit);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodParameter- Insert", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }
        public void DeleteBloodParameterById(int Id)
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
                throw new DataAccessException("Exception in MySqlBloodParameter- Delete", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }

        public void UpdateBloodParameter(BloodParameter bp)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", bp.Id);
                cmd.Parameters.AddWithValue("@ReferenceValue", bp.ReferenceValue);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodParameter-Update", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }

    }
}



