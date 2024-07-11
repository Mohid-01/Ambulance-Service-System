using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_Service_System
{
    class Employee
    {
        public string name;
        public int id = 1042;
        public string cnic;
        public string mobileNo;
        public string email;
        public string address;
        public string appliedFor;
        public string shift;
        public int review = 0;
        public int reviewCounter = 0;

        public Employee(string aname, string acnic, string amobileNo, string aemail, string aaddress, string aappliedFor, string ashift)
        {
            name = aname;
            cnic = acnic;
            mobileNo = amobileNo;
            email = aemail;
            address = aaddress;
            appliedFor = aappliedFor;
            shift = ashift;
        }
        public void Save()
        {
            using (StreamWriter sw = File.AppendText("C:/Users/newst/Documents/Data Strcuture and Algorithm Lab/Final Project/Code/Git/Ambulance Service System/bin/Debug/EmployeeData.txt"))
            {
                sw.WriteLine(name + "," + cnic + "," + mobileNo + "," + email + "," + address + "," + appliedFor + "," + review + "," + reviewCounter);
            }
            MessageBox.Show("Data of Employee is Saved");
        }

    }
}
