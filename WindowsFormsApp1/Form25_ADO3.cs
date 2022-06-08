using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form25_ADO3 : Form
    {
        public Form25_ADO3()
        {
            InitializeComponent();
        }

        private SqlDataAdapter sqlDataAdapter;
        private DataSet ds;

        private void Form25_ADO3_Load(object sender, EventArgs e)
        {
            sqlDataAdapter = new SqlDataAdapter(
               "select CustomerId , CompanyName , Country , City from Customers",
               ConfigurationManager.ConnectionStrings["NorthwindConnectionString1"].ConnectionString
               );

            ds = new DataSet();

            sqlDataAdapter.Fill(ds , "Customers");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Customers";
        }
    }
}
