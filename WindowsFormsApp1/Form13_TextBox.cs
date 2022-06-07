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
    public partial class Form13_TextBox : Form
    {
        public Form13_TextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);

            foreach (var item in textBox1.Lines)
            {
                Console.WriteLine(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ScrollBars = ScrollBars.Vertical;

            textBox2.Text = "AAAAAA\r\nAAAAAA\r\nAAAAA\r\nAAA\r\nAAA\r\nAAA\r\nAAA";

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '$';

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox3.Text);
        }
    }
}
