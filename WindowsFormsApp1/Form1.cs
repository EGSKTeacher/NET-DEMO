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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Windows form");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //output
            Console.WriteLine("Hello Windows Form");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "open by form1";
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.button1.Text = "ShowMessageBox";
            this.Text = "first windows form";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.StartPosition = FormStartPosition.CenterScreen;
            f.TopMost = true;

            f.Show();
        }

        private Form MyForm2;
        private void button5_Click(object sender, EventArgs e)
        {
            MyForm2 = new Form2();
            MyForm2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyForm2.Close();
        }
    }
}
