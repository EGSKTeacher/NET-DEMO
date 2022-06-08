using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form23_ADO1 : Form
    {
        public Form23_ADO1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerUtility utility = new CustomerUtility();

            List<Customer> customers = utility.GetCustomers();

            listBox1.DataSource = customers;

            listBox1.DisplayMember = "CustomerId";
        }
    }
}
