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

    public List<Customer> GetCustomersByCountry(string country)
    {
        if (country == null)
        {
            return null;
        }
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
           "select * from Customers where Country=@Country",
           this.ConnectionString
           );

        sqlDataAdapter.SelectCommand.Parameters.AddWithValue(
            "@Country", country);

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

    public void Insert(string customerId, string companyName, string country, string city)
    {
        SqlConnection sqlConnection = new SqlConnection(this.ConnectionString);

        SqlCommand sqlCommand = new SqlCommand(
            "insert into Customers (CustomerID , CompanyName , Country , City) " +
            "values(@CustomerID , @CompanyName , @Country , @City)",
            sqlConnection);

        sqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
        sqlCommand.Parameters.AddWithValue("@CompanyName", companyName);
        sqlCommand.Parameters.AddWithValue("@Country", country);
        sqlCommand.Parameters.AddWithValue("@City", city);

        sqlConnection.Open();
        sqlCommand.ExecuteNonQuery();
        sqlConnection.Close();
    }

    public void Update(string customerId, string companyName, string country, string city)
    {
        SqlConnection sqlConnection = new SqlConnection(this.ConnectionString);

        SqlCommand sqlCommand = new SqlCommand(
"update Customers set CompanyName = @CompanyName , " +
"Country = @Country , City = @City where CustomerId = @CustomerId",
            sqlConnection);

        sqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
        sqlCommand.Parameters.AddWithValue("@CompanyName", companyName);
        sqlCommand.Parameters.AddWithValue("@Country", country);
        sqlCommand.Parameters.AddWithValue("@City", city);

        sqlConnection.Open();
        sqlCommand.ExecuteNonQuery();
        sqlConnection.Close();
    }

    public void Delete(string customerId)
    {
        SqlConnection sqlConnection = new SqlConnection(this.ConnectionString);

        SqlCommand sqlCommand = new SqlCommand(
                "delete Customers where CustomerId = @CustomerId",
            sqlConnection);

        sqlCommand.Parameters.AddWithValue("@CustomerId", customerId);

        sqlConnection.Open();
        sqlCommand.ExecuteNonQuery();
        sqlConnection.Close();
    }
}