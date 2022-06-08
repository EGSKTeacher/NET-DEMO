using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form21_ToolStrip : Form
    {
        public Form21_ToolStrip()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(
                toolStripTextBox1.Text
                );
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(
                toolStripTextBox1.Text,
                textBox1.Text
                );
            MessageBox.Show("存檔完成");
        }
    }
}
