using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ambulance_Service_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LoginNameField.Text != "" && PasswordField.Text != "")
            {
                string path = "C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Git/Ambulance Service System/Login.txt";
                // Path for Mohid = C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Git/Ambulance Service System/Login.txt
                string[] textFromFile = new string[5];
                textFromFile = File.ReadAllLines(path);
                string admin_Name = LoginNameField.Text;
                string admin_Password = (PasswordField.Text);


                for (int i = 0; i < textFromFile.Length; i++)
                {
                    string admin_Name_List = parseData(textFromFile[i], 0);
                    string admin_Password_List = (parseData(textFromFile[i], 1));

                    if (admin_Name == admin_Name_List && admin_Password == admin_Password_List)
                    {
                        this.Hide();
                        Admin admin = new Admin();
                        admin.Show();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Fill the all Boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        static string parseData(string textFromFile, int x)
        {

            int comma = 0;
            string record = "";

            for (int i = 0; i < textFromFile.Length; i++)
            {

                if (textFromFile[i] == ',')
                {
                    comma++;
                    //i++;
                }
                else if (comma == x)
                {
                    record = record + textFromFile[i];
                }


            }
            return record;

        }
        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (LoginNameField.Text != "" && PasswordField.Text != "")
            {
                string path = "C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Git/Ambulance Service System/Receive.csv";
                // Mohid Path "C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Git/Ambulance Service System/Receive.csv"
                // Hammad Path "C://Users/fahad/OneDrive/Desktop/DSATASKS/Final Project/ambulance-service-system/Ambulance Service System/Recieve.csv"
                string[] textFromFile = new string[5];
                textFromFile = File.ReadAllLines(path);
                string employee_Name = LoginNameField.Text;
                string employee_Password = (PasswordField.Text);


                for (int i = 0; i < textFromFile.Length; i++)
                {
                    string admin_Name_List = parseData(textFromFile[i], 0);
                    string admin_Password_List = (parseData(textFromFile[i], 1));

                    if (employee_Name == admin_Name_List && employee_Password == admin_Password_List)
                    {
                        this.Hide();
                        Call call = new Call();
                        call.Show();
                    }

                }
            }
        }
    }
}
