using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.database
{
    public class DbConnection
    {
        //string connectionString = @"Data Source=DESKTOP-QQE9C8H\SQLEXPRESS;Initial Catalog=SalesDB;Integrated Security=True";
        string connectionString = @"Data Source=DESKTOP-QQE9C8H\SQLEXPRESS;Initial Catalog=AdventureWorksLT2012;Integrated Security=True";

        public DataTable sqlToSelectData(string queryString) 
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not connect to DB: " + ex);
            }
            return dt;
        }

        public void sqlToInsertUpdateDelete(string query, Dictionary<string, string> paras)
        {            
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn); 

                foreach (KeyValuePair<string, string> para in paras)
                {
                    cmd.Parameters.AddWithValue(para.Key, para.Value);
                }

                int sql_status = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not connect to DB: " + ex);
            }
        }
        
    }
}
