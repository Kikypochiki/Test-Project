using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestProject.testProjectClasses
{
    internal class Info
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }

        string mysqlcon = "server=127.0.0.1; user = root; database = testprojectdatabase; password =";

        public DataTable Select()
        {
            MySqlConnection con = new MySqlConnection(mysqlcon);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM info";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public bool Insert(Info I)
        {
            bool isSuccess = false;

            MySqlConnection con = new MySqlConnection(mysqlcon);
            try
            {
                string sql = "INSERT INTO info (NAME, DATEOFBIRTH, ADDRESS, GENDER) VALUES (@Name, @DateOfBirth, @Address, @Gender)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", I.Name);
                cmd.Parameters.AddWithValue("@DateOfBirth", I.DateOfBirth);
                cmd.Parameters.AddWithValue("@Address", I.Address);
                cmd.Parameters.AddWithValue("@Gender", I.Gender);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }
        public bool EDIT(Info I)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(mysqlcon);
            try
            {
                string sql = "UPDATE info SET NAME=@Name, DATEOFBIRTH=@DateOfBirth, ADDRESS=@Address, Gender=@Gender WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", I.id);
                cmd.Parameters.AddWithValue("@Name", I.Name);
                cmd.Parameters.AddWithValue("@DateOfBirth", I.DateOfBirth);
                cmd.Parameters.AddWithValue("@Address", I.Address);
                cmd.Parameters.AddWithValue("Gender", I.Gender);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
                if (isSuccess)
                {
                    Console.WriteLine("Record updated successfully");
                }
                else
                {
                    Console.WriteLine("Failed to update record");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Delete(Info I)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(mysqlcon);
            try
            {
                string sql = "DELETE FROM info WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", I.id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}