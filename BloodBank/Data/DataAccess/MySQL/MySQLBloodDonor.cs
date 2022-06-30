using BloodBank.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BloodBank.Data.DataAccess.Exceptions;
using System.Data;
namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLBloodDonor : IBloodDonor
    {
        private static readonly string SELECT = @"SELECT * from davaoci_krvi_detaljno
                                                    WHERE 
                                                      Ime LIKE @str OR
                                                      Prezime LIKE @str OR
                                                      JMBG LIKE @str;";
  
        private static readonly string INSERT_ADDRESS = @"INSERT into adresa values (null, @drzava, @grad, @postanskiBroj,@Ulica, @Broj);";
        private static readonly string INSERT_PERSON = @"INSERT into osoba values (null, @ime, @prezime,@JMBG,  @email, @telefon, @idAdresa);";
        private static readonly string INSERT_DONOR = @"INSERT into davalac_krvi values (@id,@imeOca,@rhFaktor, @krvnaGrupa);";
        private static readonly string UPDATE_ADDRESS = @"UPDATE adresa SET
                                                                      Drzava=@drzava,
                                                                      Grad=@grad,
                                                                      PostanskiBroj=@postanskiBroj,
                                                                      Ulica=@ulica,
                                                                      Broj = @broj
                                                                      WHERE IdAdresa=@Id;";
        private static readonly string UPDATE_PERSON = @"UPDATE osoba SET
                                                                      Ime=@ime,
                                                                      Prezime=@prezime,
                                                                      Telefon=@telefon,
                                                                      Email=@email,
                                                                      ADRESA_IdAdresa=@IdAdresa
                                                                      WHERE IdOsoba=@Id;";
        private static readonly string UPDATE_DONOR = @"UPDATE davalac_krvi SET
                                                                          KrvnaGrupa=@krvnaGrupa,
                                                                          RHFaktor=@rhFaktor
                                                                          WHERE IdOsoba=@Id;";





        public int CheckIfAddressExist(string state, string city, string postalCode, string street, string streetNumber)
        {
            int result = -1;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "provjeri_adresu";
                cmd.Parameters.AddWithValue("@pDrzava", state);
                cmd.Parameters["@pDrzava"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pGrad", city);
                cmd.Parameters["@pGrad"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pPostanskiBroj", postalCode);
                cmd.Parameters["@pPostanskiBroj"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pUlica", street);
                cmd.Parameters["@pUlica"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pBroj", streetNumber);
                cmd.Parameters["@pBroj"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pId", MySqlDbType.Int32);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = Convert.ToInt32(cmd.Parameters["@pId"].Value.ToString());
               
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonors-CheckIfAddressExist", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }


        public int CheckNumberOfAddressReference(int IdAddress)
        {
            int result = -1;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "broj_referenci_na_adresu";
                cmd.Parameters.AddWithValue("@pId", IdAddress);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pBroj", MySqlDbType.Int32);
                cmd.Parameters["@pBroj"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = Convert.ToInt32(cmd.Parameters["@pBroj"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonors-CheckNumberOfAddressReference", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void DeleteBloodDonorById(int Id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
           
            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "obrisi_davaoca";
                cmd.Parameters.AddWithValue("@pId", Id);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonor-Delete", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(conn);
            }
        }

        public List<BloodDonor> GetBloodDonors(string filter)
        {
            List<BloodDonor> result = new List<BloodDonor>();
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
                    result.Add(new BloodDonor()
                    {
                        Person = new Person()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            JMBG = reader.GetString(3),
                            Phone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                            Email = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                            Address = new Address()
                            {
                                Id = reader.GetInt32(6),
                                State = reader.GetString(7),
                                City = reader.GetString(8),
                                PostalCode = reader.GetString(9),
                                Street = reader.GetString(10),
                                StreetNumber = reader.GetString(11)
                            }, 
                            
                        },
                        FathersName = reader.IsDBNull(12) ? string.Empty : reader.GetString(12),
                        BloodType = new BloodType()
                        {
                            Name = reader.IsDBNull(13) ? string.Empty: reader.GetString(13)
                            
                        },
                        RHFactor = new RHFactor()
                        {
                            Name = reader.IsDBNull(14) ?string.Empty : reader.GetString(14)

                        },
                        NumberOfDonations=reader.GetInt32(15)

                    }) ; 
                  
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonors-Select", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void InsertBloodDonor(BloodDonor donor)
        {
            
            Address address = donor.Person.Address;
            int IdAddress = CheckIfAddressExist(address.State, address.City, address.PostalCode, address.Street, address.StreetNumber);
          
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;


            try
            {
                if (IdAddress == -1)
                {
                    donor.Person.Address.Id = InsertAddress(address);
                }
                else
                    donor.Person.Address.Id = IdAddress;
          

                conn = MySQLUtil.GetConnection();
                int result = -1;

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "provjeri_JMBG";
                cmd.Parameters.AddWithValue("@pJMBG", donor.Person.JMBG);
                cmd.Parameters["@pJMBG"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pId", MySqlDbType.Int32);
                cmd.Parameters["@pId"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@pId"].Value.ToString());

                if (result != -1)
                {
                   
                        donor.Person.Id = result;
                    
                }
                else
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = INSERT_PERSON;
                    cmd.Parameters.AddWithValue("@ime", donor.Person.FirstName);
                    cmd.Parameters.AddWithValue("@prezime", donor.Person.LastName);
                    cmd.Parameters.AddWithValue("@JMBG", donor.Person.JMBG);
                    cmd.Parameters.AddWithValue("@telefon", donor.Person.Phone.Equals("")? null : donor.Person.Phone);
                    cmd.Parameters.AddWithValue("@email", donor.Person.Email.Equals("") ? null : donor.Person.Email);
                    cmd.Parameters.AddWithValue("@idAdresa", donor.Person.Address.Id);
                    cmd.ExecuteNonQuery();
                    donor.Person.Id = (int)cmd.LastInsertedId;
                    

                }

                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_DONOR;
                cmd.Parameters.AddWithValue("@id", donor.Person.Id);
                cmd.Parameters.AddWithValue("@imeOca", donor.FathersName.Equals("") ? null : donor.FathersName);
                cmd.Parameters.AddWithValue("@krvnaGrupa", donor.BloodType.Name.Equals("") ? null : donor.BloodType.Name);
                cmd.Parameters.AddWithValue("@rhFaktor", donor.RHFactor.Name.Equals("") ? null : donor.RHFactor.Name);
  
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonor-InsertDonor", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }


        public int InsertAddress(Address a)
        {
            int result = -1;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_ADDRESS;
                cmd.Parameters.AddWithValue("@drzava", a.State);
                cmd.Parameters.AddWithValue("@grad", a.City);
                cmd.Parameters.AddWithValue("@postanskiBroj", a.PostalCode);
                cmd.Parameters.AddWithValue("@ulica", a.Street);
                cmd.Parameters.AddWithValue("@broj", a.StreetNumber);
                cmd.ExecuteNonQuery();
                result= (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonor-InsertAddress", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

            public void UpdateBloodDonor(BloodDonor d)
        {
            Address a = d.Person.Address;
            int newIdAddress = CheckIfAddressExist(a.State, a.City, a.PostalCode, a.Street, a.StreetNumber);

            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();

                if (newIdAddress == -1 && CheckNumberOfAddressReference(d.Person.Address.Id) == 1) //ako na staroj adresi zivi samo jedna osoba- update
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = UPDATE_ADDRESS;
                    cmd.Parameters.AddWithValue("@drzava", d.Person.Address.State);
                    cmd.Parameters.AddWithValue("@grad", d.Person.Address.City);
                    cmd.Parameters.AddWithValue("@postanskiBroj", d.Person.Address.PostalCode);
                    cmd.Parameters.AddWithValue("@ulica", d.Person.Address.Street);
                    cmd.Parameters.AddWithValue("@broj", d.Person.Address.StreetNumber);
                    cmd.Parameters.AddWithValue("@Id", d.Person.Address.Id);
                    cmd.ExecuteNonQuery();
                }
                else if (newIdAddress != -1)//ako postoji u bazi nova adresa
                {
                    d.Person.Address.Id = newIdAddress;
                }
                else//ako na staroj adresi zivi vise osoba ili  ne postoji adresa- dodaj novu adresu
                    {
                        d.Person.Address.Id = InsertAddress(d.Person.Address);
                    }
                

                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_PERSON;
                cmd.Parameters.AddWithValue("@ime", d.Person.FirstName);
                cmd.Parameters.AddWithValue("@prezime", d.Person.LastName);
                cmd.Parameters.AddWithValue("telefon", d.Person.Phone.Equals(string.Empty)?null:d.Person.Phone);
                cmd.Parameters.AddWithValue("@email", d.Person.Email.Equals(string.Empty)? null: d.Person.Email);
                cmd.Parameters.AddWithValue("@IdAdresa",d.Person.Address.Id);
                cmd.Parameters.AddWithValue("@Id", d.Person.Id);
                cmd.ExecuteNonQuery();


                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_DONOR;
                cmd.Parameters.AddWithValue("@krvnaGrupa", d.BloodType.Name.Equals(string.Empty)? null: d.BloodType.Name);
                cmd.Parameters.AddWithValue("@rhFaktor", d.RHFactor.Name.Equals(string.Empty)? null: d.RHFactor.Name);
                cmd.Parameters.AddWithValue("@Id", d.Person.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonor-Update", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
        }
    }

}

