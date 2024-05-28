using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.database;

namespace WpfApp1.models
{
    public class Customer
    {
        //public int customerId { get; set; }
        //public string firstName { get; set; }
        //public string lastName { get; set; }
        //public string company { get; set; }
        //public string email { get; set; }
        //public string phone { get; set; }

        database.DbConnection conn = new database.DbConnection();
        public DataTable getCustomerData()
        {
            DataTable dt = new DataTable();
            dt = conn.sqlToSelectData("SELECT TOP 10 CustomerID, FirstName, LastName, CompanyName, EmailAddress, Phone FROM SalesLT.Customer");
            return dt;
        }
        public void addCustomer(string firstName, string lastName, string company, string email, string phone)
        {
            Dictionary<string, string> paras = new Dictionary<string, string>();
            paras.Add("@firstName", firstName);
            paras.Add("@lastName", lastName);
            paras.Add("@company", company);
            paras.Add("@email", email);
            paras.Add("@phone", phone);

            
            //string query = "INSERT INTO SalesLT.Customer (CustomerID, FirstName, LastName, CompanyName, EmailAddress, Phone) VALUES (@customerId, @firstName, @lastName, @company, @email, @phone)";
            string query = "INSERT INTO SalesLT.Customer (FirstName, LastName, CompanyName, EmailAddress, Phone) VALUES (@firstName, @lastName, @company, @email, @phone)";
            conn.sqlToInsertUpdateDelete(query, paras);
        }
    }
}
