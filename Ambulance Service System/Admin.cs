﻿using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new ManageEmployee();
            newForm.Show();
        }

        private void performance_Click(object sender, EventArgs e)
        {
            var newForm = new Report();
            newForm.Show();
        }

        private void Parking_Click(object sender, EventArgs e)
        {
            var newForm = new Parking_Management();
            newForm.Show();
        }

        private void manage_Employee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreaData_Click(object sender, EventArgs e)
        {
            var newForm = new RecieveData1();
            newForm.Show();
        }
    }
}
