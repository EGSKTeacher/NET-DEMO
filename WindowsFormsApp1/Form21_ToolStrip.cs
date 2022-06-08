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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(
    toolStripTextBox1.Text
    );
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(
    toolStripTextBox1.Text,
    textBox1.Text
    );
            MessageBox.Show("存檔完成");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}
