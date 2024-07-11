using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Ambulance_Service_System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_Service_System
{
    public partial class Show_Report : Form
    {
        public static string rev;
        public static string revC;
        public string ans;
        public float result;
        public Show_Report()
        {
            InitializeComponent();
        }

        public void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void Show_Report_Load(object sender, EventArgs e)
        {
            string value = Report.idR;
            FileStream fs = new FileStream("EmployeeData.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                string[] values = str.Split(',');
                if (values[1] == value)
                {
                    rev = values[8];
                    revC = values[9];
                    str = sr.ReadLine();
                }
            }
            sr.Close();
            fs.Close();
            Review c = new Review(rev, revC);
            result = c.calculate();
            ans = result.ToString();
            //MessageBox.Show(ans);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Reviews"].Points.AddXY("Employee", result);
            chart1.Series["Reviews"].Points.AddXY("Employee", 5);
        }
    }
}
