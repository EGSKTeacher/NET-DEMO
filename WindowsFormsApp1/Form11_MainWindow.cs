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
    public partial class Form11_MainWindow : Form
    {
        public Form11_MainWindow()
        {
            InitializeComponent();
        }

        private void Form11_MainWindow_Load(object sender, EventArgs e)
        {
            Form10_Dock f = new Form10_Dock();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();

            this.label1.Text = f.UserName + " 您好!";
        }
    }
}
