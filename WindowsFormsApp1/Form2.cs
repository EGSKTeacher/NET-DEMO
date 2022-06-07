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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ControlBox = false;

            //this.MinimizeBox = false;

            //this.MaximizeBox = false;

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "testButton";
            btn.Location = new Point(200, 100);

            btn.Click += Btn_Click;

            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
