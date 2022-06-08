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
    public partial class Form22_Events : Form
    {
        public Form22_Events()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("MouseEnter");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Console.WriteLine("MouseHover");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("MouseLeave");

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format(
                "x:{0} , y:{1}" , e.X , e.Y);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = e.Button.ToString();
        }
    }
}
