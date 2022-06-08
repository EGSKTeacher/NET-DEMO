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
    public partial class Form18_DataBinding : Form
    {
        public Form18_DataBinding()
        {
            InitializeComponent();
        }

        private void Form18_DataBinding_Load(object sender, EventArgs e)
        {
            List<Member> members = new List<Member>()
            {
                new Member(){ Id=1 , Name="mary" },
                new Member(){ Id=2 , Name="john" },
                new Member(){ Id=3 , Name="andy" }
            };

            comboBox1.DataSource = members;
            //comboBox1.DataBind()

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Console.WriteLine(comboBox1.SelectedValue);

            //Console.WriteLine(comboBox1.SelectedItem);
            Member member = comboBox1.SelectedItem as Member;
            Console.WriteLine(member.Name);
        }
    }

    class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
