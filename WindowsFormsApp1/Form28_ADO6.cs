﻿using System;
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
    public partial class Form28_ADO6 : Form
    {
        public Form28_ADO6()
        {
            InitializeComponent();
        }

        private void Form28_ADO6_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);

            bindingSource1.DataSource = northwindDataSet1.Customers;

            dataGridView1.DataSource = bindingSource1;

        }
    }
}
