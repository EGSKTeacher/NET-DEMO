using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public class CustomerUtility
{
    private string ConnectionString;
    public CustomerUtility()
    {
        ConnectionString =
ConfigurationManager.ConnectionStrings["NorthwindConnectionString1"].ConnectionString;
    }

    public List<Customer> GetCustomers()
    {
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
           "select * from Customers",
           this.ConnectionString
           );

        DataTable table = new DataTable();

        sqlDataAdapter.Fill(table);

        //DataTable => List<Customer>
        List<Customer> customers =
            table.AsEnumerable().
            Select(row => new Customer()
            {
                CustomerID = row["CustomerID"].ToString(),
                CompanyName = row["CompanyName"].ToString(),
                Country = row["Country"].ToString(),
                City = row["City"].ToString()
            }).ToList();

        return customers;
    }
}