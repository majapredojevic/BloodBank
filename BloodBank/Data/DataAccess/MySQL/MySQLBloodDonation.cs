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
    public class MySQLBloodDonation : IBloodDonation
    {
        private static readonly string INSERT_BLOOD_DONATION = @"INSERT INTO doniranje_krvi values (null,sysdate(), @hemoglobin, @krvniPritisak, @puls,
                                                    @zdravstvenoStanje, @davalac, @doktor, @poslovnica,@jedinicaKrvi);";
        private static readonly string INSERT_BLOOD_BAG = @"INSERT INTO jedinica_krvi values(null, @kolicina,null);";
        private static readonly string UPDATE_BLOOD_BAG = @"UPDATE jedinica_krvi SET
                                                                      Kolicina=@Capacity
                                                                      WHERE IdJedinicaKrvi=@Id;";
        private static readonly string UPDATE_BLOOD_DONATION = @"UPDATE doniranje_krvi SET
                                                                      Hemoglobin=@Hemoglobin,
                                                                      KrvniPritisak=@BloodPressure,
                                                                      ZdravstvenoStanje=@HealthCondition,
                                                                      Puls=@Pulse
                                                                      WHERE IdDoniranjeKrvi=@Id;";
        private static readonly string SELECT = @"SELECT * FROM doniranje_krvi_detaljno
                                                  WHERE JMBG LIKE @str OR
                                                        Naziv LIKE @str;";
       
        

        public List<BloodDonation> GetBloodDonations(string filter)
        {
            List<BloodDonation> result = new List<BloodDonation>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
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
                    result.Add(new BloodDonation()
                    {
                        Id = reader.GetInt32(0),
                        DateOfDonation = reader.GetDateTime(1),
                        Hemoglobin = reader.GetInt32(2),
                        BloodPressure = reader.GetString(3),
                        Pulse = reader.GetInt32(4),
                        HealthCondition = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Donor = new BloodDonor()
                        {
                            Person = new Person()
                            {
                                Id = reader.GetInt32(6),
                                FirstName = reader.GetString(7),
                                LastName = reader.GetString(8),
                                JMBG = reader.GetString(9)
                            },
                            FathersName = reader.IsDBNull(10)? string.Empty : reader.GetString(10)
                        },
                        BloodBag = new BloodBag()
                        {
                            Id = reader.GetInt32(11),
                            Capacity = reader.GetInt32(12)
                        },
                        Office = new Office()
                        {
                            Name = reader.GetString(13)
                        },
                        Doctor = new Employee()
                        {
                            Title = reader.GetString(14),
                            Person = new Person()
                            {
                                FirstName = reader.GetString(15),
                                LastName = reader.GetString(16)
                            }
                        }
                        
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonation-Select", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;          
        }

        public int InsertBloodDonation(BloodDonation donation)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
           
            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_BLOOD_BAG;
                cmd.Parameters.AddWithValue("@kolicina", donation.BloodBag.Capacity);
                cmd.ExecuteNonQuery();
                donation.BloodBag.Id = (int)cmd.LastInsertedId;


                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_BLOOD_DONATION;
                cmd.Parameters.AddWithValue("@hemoglobin", donation.Hemoglobin);
                cmd.Parameters.AddWithValue("@krvniPritisak", donation.BloodPressure);
                cmd.Parameters.AddWithValue("@puls", donation.Pulse);
                cmd.Parameters.AddWithValue("@zdravstvenoStanje", donation.HealthCondition.Equals("")? null:donation.HealthCondition);
                cmd.Parameters.AddWithValue("@davalac", donation.Donor.Person.Id);
                cmd.Parameters.AddWithValue("@doktor", donation.Doctor.Person.Id);
                cmd.Parameters.AddWithValue("@poslovnica", donation.Office.Id);
                cmd.Parameters.AddWithValue("@jedinicaKrvi", donation.BloodBag.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonation-Insert", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly( conn);
            }
            return donation.BloodBag.Id;
        }


        public void UpdateBloodDonation(BloodDonation donation)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();

                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_BLOOD_DONATION;
                cmd.Parameters.AddWithValue("@Id", donation.Id);
                cmd.Parameters.AddWithValue("@Hemoglobin", donation.Hemoglobin);
                cmd.Parameters.AddWithValue("@BloodPressure", donation.BloodPressure);
                cmd.Parameters.AddWithValue("@Pulse", donation.Pulse);
                cmd.Parameters.AddWithValue("@HealthCondition", donation.HealthCondition.Equals("") ? null : donation.HealthCondition);
                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_BLOOD_BAG;
                cmd.Parameters.AddWithValue("@Id", donation.BloodBag.Id);
                cmd.Parameters.AddWithValue("@Capacity", donation.BloodBag.Capacity);
               
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
