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
    public partial class Form15_ListBox : Form
    {
        public Form15_ListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] ary = new string[] { "XX", "YY", "ZZ" };
            listBox1.Items.AddRange(ary);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, "OO");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(listBox1.SelectedItem);

            foreach (var item in listBox1.SelectedItems)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
