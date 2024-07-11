using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_Service_System
{
    public partial class RecieveData1 : Form
    {
        public RecieveData1()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecieveData_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Wapda Town";
            textBox2.Text = "220 E";
            textBox3.Text = "Jawad";
            textBox4.Text = "0306-6795671";
            textBox5.Text = "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Township";
            textBox2.Text = "180 B";
            textBox3.Text = "Talha";
            textBox4.Text = "0305-6724281";
            textBox5.Text = "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Johar Town";
            textBox2.Text = "210 F";
            textBox3.Text = "Asad";
            textBox4.Text = "0305-6721671";
            textBox5.Text = "3";
        }
    }
}
