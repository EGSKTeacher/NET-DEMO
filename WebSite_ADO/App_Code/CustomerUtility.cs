using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;


public class CustomerUtility
{
    private string ConnectionString;
    public CustomerUtility()
    {
        ConnectionString =
ConfigurationManager.ConnectionStrings["NorthwindConnectionString1"].ConnectionString;
    }

    public void GetCustomers()
    {

    }
}