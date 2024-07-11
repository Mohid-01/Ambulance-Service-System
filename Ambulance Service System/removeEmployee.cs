using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambulance_Service_System;
using System.Windows.Forms;

namespace Ambulance_Service_System
{
    public partial class removeEmployee : Form
    {
        public removeEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectJobID_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobID.Text = SelectJobID.Text;
        }

        private void removeEmployee_Load(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader("C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Testing/Testing/bin/Debug/netcoreapp3.1/EmployeeData.txt"))
            {

                string ln;

                while ((ln = file.ReadLine()) != null)
                {   
                    string[] values = ln.Split(',');
                    SelectJobID.Items.Add(values[1]);
                }
                file.Close();
            }
        }

        private void jobID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Git/Ambulance Service System/bin/Debug/EmployeeData.txt";
            string word = Convert.ToString(jobID.Text); // delete the selected line  
            var oldLines = System.IO.File.ReadAllLines(path);
            var newLines = oldLines.Where(line => !line.Contains(word));
            System.IO.File.WriteAllLines(path, newLines);
            FileStream obj = new FileStream(path, FileMode.Append);
            obj.Close();
            // once deleted the selected line and once again read the text file and diplay the new text file in listBox  
            FileInfo fi = new FileInfo("C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Git/Ambulance Service System/bin/Debug/EmployeeData.txt");
            using (StreamReader sr2 = fi.OpenText())
            {
                string s = "";
                while ((s = sr2.ReadLine()) != null)
                {
                    jobID.Text = s;
                }
                sr2.Close();
            }
            FileStream obj1 = new FileStream(path, FileMode.Append);
            obj1.Close();

            MessageBox.Show("Employee is Fired");
            this.Close();

        }

    }
}

