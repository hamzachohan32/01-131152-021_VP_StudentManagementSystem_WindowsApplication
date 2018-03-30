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
using Microsoft.VisualBasic;

namespace StudentManagementApplication
{
    public partial class ManagementSystemMain : Form
    {
        public ManagementSystemMain()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
               
                AddStudent addS = new AddStudent();
                addS.Show();
                this.Hide();

            }
            if (radioButton2.Checked)
            {
                DeleteStudent delS = new DeleteStudent();
                delS.Show();
                this.Hide();
            }
            if (radioButton4.Checked)
            {
                search searchS = new search();
                searchS.Show();
                this.Hide();
            }
            if (radioButton5.Checked)
            {

                topStudents topS = new topStudents();
                topS.Show();
                this.Hide();

            }
            if (radioButton3.Checked)
            {

                MarkAttandence markS = new MarkAttandence();
                markS.Show();
                this.Hide();

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
