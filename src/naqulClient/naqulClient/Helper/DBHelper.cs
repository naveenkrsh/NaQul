using System;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace naqulClient.Helper
{
    public class DBHelper
    {

        public DBHelper(string connectionString)
        {
           this.connectionString=connectionString;
        }
        private readonly string connectionString;//= "server=localhost;port=3306;database=northwind;user=root;password=Password@123";// ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
       
        public DataSet GetDataFromDB(string contents)
        {


            DataSet ds = new DataSet();
            using (MySqlConnection con = GetConnection())
            {
                //string query = "SELECT * FROM Customers";
                using (MySqlCommand cmd = new MySqlCommand(contents.ToLower(), con))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(ds);
                    }
                }
            }
            return ds;
        }

        public void SaveSqlQuery(string text)
        {
           
            string sqlStatement = $"Insert Into recent_queries(text) Values('{text}')";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sqlStatement,con))
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public  MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
