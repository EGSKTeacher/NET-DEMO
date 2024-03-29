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
    public partial class Form19_TrackBar : Form
    {
        public Form19_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.LargeChange = 20;
        }
    }
}
