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
    public partial class Form7_TabControl : Form
    {
        public Form7_TabControl()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add("newtab");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.Multiline = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Bottom;
        }
    }
}
