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
    public partial class Form10_Dock : Form
    {
        public Form10_Dock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mary" && textBox2.Text == "123")
            {
                this.Close();
            }
            else
            {
                this.label3.Text = "Error!";
            }
        }

        private void Form10_Dock_Load(object sender, EventArgs e)
        {
            this.textBox2.UseSystemPasswordChar = true;
        }

        public string UserName
        {
            get
            {
                return this.textBox1.Text;
            }
        }
    }
}
