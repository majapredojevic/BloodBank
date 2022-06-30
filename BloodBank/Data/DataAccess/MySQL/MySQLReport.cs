using BloodBank.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBank.Data.DataAccess.Exceptions;
using MySql.Data.MySqlClient;

namespace BloodBank.Data.DataAccess.MySQL
{
    public class MySQLReport : IReport
    {
        private static readonly string INSERT = @"INSERT INTO izvjestaj_analize values (@Id, sysdate(),@IdLaborant,@IdRH,@IdBloodType);";
        private static readonly string INSERT_REPORT_BLOOD_PARAMETERS = @"INSERT INTO izvjestaj_analize_krvni_parametar values (@IdReport, @IdBloodParameter, @Value);";
        private static readonly string INSERT_REPORT_VIRUSES = @"INSERT INTO izvjestaj_analize_virus values (@IdReport, @IdVirus, @Value);";
        private static readonly string SELECT = @"SELECT * FROM izvjestaj_analize_detaljno
                                                    WHERE IdJedinicaKrvi LIKE @str;";
        private static readonly string SELECT_BLOOD_PARAMETERS_BY_REPORT_ID = @"SELECT p.Id, p.Naziv, p.ReferentnaVrijednost, p.MjernaJedinica, i.Vrijednost FROM izvjestaj_analize_krvni_parametar i
                                                                         INNER JOIN krvni_parametar p ON p.Id = i.IdKrvniParametar
                                                                         WHERE IdIzvjestajAnalize LIKE @id;";
        private static readonly string SELECT_VIRUSES_BY_REPORT_ID = @"SELECT v.IdVirus, v.Naziv, v.ReferentnaVrijednost, v.MjernaJedinica, i.Vrijednost FROM izvjestaj_analize_virus i
                                                                      INNER JOIN virus v ON v.IdVirus = i.IdVirus
                                                                      WHERE IdIzvjestaj LIKE @id;";


        public List<ReportBloodParameter> GetBloodParametersByReportId(int id)
        { 
            List<ReportBloodParameter> bloodParameters= new List<ReportBloodParameter>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BLOOD_PARAMETERS_BY_REPORT_ID;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bloodParameters.Add(new ReportBloodParameter()
                    {
                        bloodParameter = new BloodParameter()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            ReferenceValue = reader.GetString(2),
                            Unit = reader.GetString(3)
                        },
                        value = reader.GetDecimal(4)
                    });
                }
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReport-Select", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return bloodParameters;
        }

        public List<Report> GetReports(string filter)
        {
            List<Report> reports = new List<Report>();
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
                    reports.Add(new Report()
                    {
                        bloodBag = new BloodBag()
                        {
                            Id = reader.GetInt32(0),
                            Capacity = reader.GetInt32(1)
                        },
                        dateTime = reader.GetDateTime(2),
                        rhFactor = new RHFactor()
                        {
                            Name = reader.GetString(3)
                        },
                        bloodType = new BloodType()
                        {
                            Name = reader.GetString(4)
                        },
                        laborant = new Employee()
                        {
                            Title = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                            Person = new Person()
                            {
                                FirstName = reader.GetString(6),
                                LastName = reader.GetString(7)
                            }
                        }
          
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReport-Select", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return reports;
        }

       public List<ReportViruses> GetReportVirusesByReportId(int id)
        {
            List<ReportViruses> viruses = new List<ReportViruses>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = MySQLUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_VIRUSES_BY_REPORT_ID;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    viruses.Add(new ReportViruses()
                    {
                        virus = new Virus()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            ReferenceValue = reader.GetString(2),
                            Unit = reader.GetString(3)
                        },
                        value = reader.GetDecimal(4)
                    });
                }
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlReport-Select", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(reader, conn);
            }
            return viruses;
        }

        public void InsertReport(Report r, List<ReportBloodParameter> reportBloodParameters, List<ReportViruses> reportViruses)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = MySQLUtil.GetConnection();

                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Id", r.bloodBag.Id);
                cmd.Parameters.AddWithValue("@IdLaborant", r.laborant.Person.Id);
                cmd.Parameters.AddWithValue("@IdRH", r.rhFactor.Name);
                cmd.Parameters.AddWithValue("@IdBloodType", r.bloodType.Name);
                cmd.ExecuteNonQuery();

                foreach (var bloodParameter in reportBloodParameters)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = INSERT_REPORT_BLOOD_PARAMETERS;
                    cmd.Parameters.AddWithValue("@IdReport", bloodParameter.report.bloodBag.Id);
                    cmd.Parameters.AddWithValue("@IdBloodParameter", bloodParameter.bloodParameter.Id);
                    cmd.Parameters.AddWithValue("@Value", bloodParameter.value);
                    cmd.ExecuteNonQuery();
                }

                foreach (var virus in reportViruses)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = INSERT_REPORT_VIRUSES;
                    cmd.Parameters.AddWithValue("@IdVirus", virus.virus.Id);
                    cmd.Parameters.AddWithValue("@Value", virus.value);
                    cmd.Parameters.AddWithValue("@IdReport", virus.report.bloodBag.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBloodDonation-Insert", ex);
            }
            finally
            {
                MySQLUtil.CloseQuietly(conn);
            }
           
        }
    }
}
