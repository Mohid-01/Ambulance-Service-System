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
    public partial class Call : Form
    {
        public string counter;
        public Call()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Amboulance # 1");
            s.Push("Amboulance # 2");
            s.Push("Amboulance # 3");           
            Queue<string> q = new Queue<string>();
            Queue<string> p = new Queue<string>();
            using (StreamReader file = new StreamReader("C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Testing/Testing/bin/Debug/netcoreapp3.1/EmployeeData.txt"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] values = ln.Split(',');
                    if (values[6] == "Driver")
                    {
                        q.Enqueue(values[0]);
                    }
                    if (values[6] == "Paramedic")
                    {
                        p.Enqueue(values[0]);
                    }
                }
                file.Close();

                MessageBox.Show(s.Pop() + " is Dispatched with Driver " + q.Dequeue() + " and Paramedic " + p.Dequeue());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stack<string> s1 = new Stack<string>();
            s1.Push("Amboulance # 4");
            s1.Push("Amboulance # 5");
            s1.Push("Amboulance # 6");
            Queue<string> q1 = new Queue<string>();
            Queue<string> p1 = new Queue<string>();
            using (StreamReader file = new StreamReader("C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Testing/Testing/bin/Debug/netcoreapp3.1/EmployeeData.txt"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] values = ln.Split(',');
                    if (values[6] == "Driver")
                    {
                        q1.Enqueue(values[0]);
                    }
                    if (values[6] == "Paramedic")
                    {
                        p1.Enqueue(values[0]);
                    }
                }
                file.Close();

                MessageBox.Show(s1.Pop() + " is Dispatched with Driver " + q1.Dequeue() + " and Paramedic " + p1.Dequeue());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stack<string> s2 = new Stack<string>();
            s2.Push("Amboulance # 7");
            s2.Push("Amboulance # 8");
            s2.Push("Amboulance # 9");
            Queue<string> q2 = new Queue<string>();
            Queue<string> p2 = new Queue<string>();
            using (StreamReader file = new StreamReader("C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Testing/Testing/bin/Debug/netcoreapp3.1/EmployeeData.txt"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] values = ln.Split(',');
                    if (values[6] == "Driver")
                    {
                        q2.Enqueue(values[0]);
                    }
                    if (values[6] == "Paramedic")
                    {
                        p2.Enqueue(values[0]);
                    }
                }
                file.Close();

                MessageBox.Show(s2.Pop() + " is Dispatched with Driver " + q2.Dequeue() + " and Paramedic " + p2.Dequeue());

            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
