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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_Employee add = new add_Employee();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            removeEmployee remove = new removeEmployee();
            remove.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
