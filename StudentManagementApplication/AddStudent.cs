using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApplication
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementSystemMain obj = new ManagementSystemMain();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DuplicateCheck obj = new DuplicateCheck();
            bool check = obj.isDuplicate(Student_ID.Text.Trim());
            if (check == true)
            {
                MessageBox.Show("Id Already Exists");
            }
            else
            {
                string data = Student_ID.Text.Trim() + ";" + stdName.Text + ";" + stdSemester.Text + ";" + stdCGPA.Text + ";" + stdDept.Text + ";" + stdUniversity.Text;
                StreamWriter file = new StreamWriter("Data.txt", true);
                file.Write(data);
                file.WriteLine();
                file.Close();
            }

         
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
