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
    public partial class add_Employee : Form
    {
        public add_Employee()
        {
            InitializeComponent();
        }

        private void manage_Employee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            string name = NameEmployee.Text;
            string cnic = Passport.Text;
            string mobile = MobileNumber.Text;
            string email = Email.Text;
            string address = Address.Text;
            string appliedfor = comboBox1.Text;
            string shift = comboBox2.Text;

            Employee emp = new Employee(name, cnic, mobile, email, address, appliedfor, shift);
            emp.Save();

        }

        private void NameEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passport_TextChanged(object sender, EventArgs e)
        {

        }

        private void MobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void add_Employee_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
