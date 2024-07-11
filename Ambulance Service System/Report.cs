using System;
using System.IO;
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
    public partial class Report : Form
    {
        public static string idR;
        public Report()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectJobID_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobID.Text = selectJobID.Text;
            idR = JobID.Text;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader("C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Testing/Testing/bin/Debug/netcoreapp3.1/EmployeeData.txt"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] values = ln.Split(',');
                    selectJobID.Items.Add(values[1]);
                }
                file.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectJobID_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Show_Report();
            newForm.Show();
        }
    }
}

