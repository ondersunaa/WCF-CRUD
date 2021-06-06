using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NorthwindService.Models;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NorthwindService" in both code and config file together.
    public class NorthwindService : INorthwindService
    {
        string dbPath = System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public void DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(dbPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(("DELETE FROM Personels WHERE Id = " + id), con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        public List<Employee> GetAllEmployees()
        {

            using (SqlConnection con = new SqlConnection(dbPath))
            {

                string sql = "select * from Personels";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    List<Employee> model = new List<Employee>();
                    command.CommandType = CommandType.Text;
                    con.Open();
                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            model.Add(new Employee
                            {
                                EmployeeId = Convert.ToInt32(sdr["Id"]),
                                GirisSaati = Convert.ToDateTime(sdr["giris_saati"]),
                                AdSoyad = sdr["ad_soyad"].ToString(),
                                TcNo = sdr["tc_kimlik_no"].ToString(),
                                Aciklama = sdr["aciklama"].ToString()
                            });
                        }
                    }
                    con.Close();
                    return model;
                }


            }


        }

        public Employee GetEmployeeById(int id)
        {
            using (SqlConnection con = new SqlConnection(dbPath))
            {
                Employee model = new Employee();
                con.Open();
                using (SqlCommand cmd = new SqlCommand(("select * FROM Personels WHERE Id = " + id), con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            model.EmployeeId = Convert.ToInt32(read["Id"]);
                            model.GirisSaati = Convert.ToDateTime(read["giris_saati"]);
                            model.AdSoyad = read["ad_soyad"].ToString();
                            model.TcNo = read["tc_kimlik_no"].ToString();
                            model.Aciklama = read["aciklama"].ToString();
                        }
                        con.Close();
                        return model;
                    }
                   
                }

            }
        }

        public void InsertEmployee(Employee model)
        {
            using (SqlConnection con = new SqlConnection(dbPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(("INSERT INTO Personels (ad_soyad, tc_kimlik_no, giris_saati, aciklama) VALUES(@adsoyad, @tc, @saat, @aciklama)"), con))
                {
                    cmd.Parameters.AddWithValue("@adsoyad", model.AdSoyad);
                    cmd.Parameters.AddWithValue("@tc", model.TcNo);
                    cmd.Parameters.AddWithValue("@saat", model.GirisSaati);
                    cmd.Parameters.AddWithValue("@aciklama", model.Aciklama);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            
        }

        public void UpdateEmployee(Employee model)
        {
            using (SqlConnection con = new SqlConnection(dbPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(("update Personels set ad_soyad = @adsoyad , tc_kimlik_no = @tc, giris_saati = @saat , aciklama = @aciklama where Id = @id "), con))
                {
                    cmd.Parameters.AddWithValue("@adsoyad", model.AdSoyad);
                    cmd.Parameters.AddWithValue("@tc", model.TcNo);
                    cmd.Parameters.AddWithValue("@saat", model.GirisSaati);
                    cmd.Parameters.AddWithValue("@aciklama", model.Aciklama);
                    cmd.Parameters.AddWithValue("@id", model.EmployeeId);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
    }
}
