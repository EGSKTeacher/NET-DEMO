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
    public partial class Form14_MaskedTextBox : Form
    {
        public Form14_MaskedTextBox()
        {
            InitializeComponent();
        }

        //https://docs.microsoft.com/zh-tw/dotnet/api/system.windows.forms.maskedtextbox.mask?view=netframework-4.7.2&f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(System.Windows.Forms.MaskedTextBox.Mask)%3Bk(System.Windows.Forms.MaskedTextBox)%3Bk(VS.Properties)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%253Dv4.7.2)%26rd%3Dtrue
        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            //maskedTextBox2.Text
            DateTime d;
            if (DateTime.TryParse(maskedTextBox2.Text , out d))
            {
                label1.Text = "OK";
            }
            else
            {
                label1.Text = "Error";
            }

        }
    }
}
