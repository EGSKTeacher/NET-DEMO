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
    public partial class Form20_NotifyIcon : Form
    {
        public Form20_NotifyIcon()
        {
            InitializeComponent();
        }

        private void Form20_NotifyIcon_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            //MessageBox.Show("不能關閉");

            this.Hide();

            notifyIcon1.ShowBalloonTip(2000);
        }
    }
}
