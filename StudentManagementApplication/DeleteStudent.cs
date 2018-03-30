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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = Student_ID.Text.Trim();
            string unsplitedData;
            string[] store = new string[6];
            StreamReader obj = new StreamReader("Data.txt");
            StreamWriter obj1 = new StreamWriter("CloneData.txt");
            while ((unsplitedData = obj.ReadLine()) != null)
            {
                store = unsplitedData.Split(';');
                if (data != store[0])
                {
                    MessageBox.Show(store[0]);
                    obj1.Write(store[0] + ';' + store[1] + ';' + store[2] + ';' + store[3] + ';' + store[4] + ';' + store[5]);
                    obj1.WriteLine();
                }

            }
            obj.Close();
            StreamWriter o1 = new StreamWriter("Data.txt");
            o1.Close();
            obj.Close();
            obj1.Close();
            StreamReader obj3 = new StreamReader("CloneData.txt");
            StreamWriter obj4 = new StreamWriter("Data.txt");
            while ((unsplitedData = obj3.ReadLine()) != null)
            {
                obj4.WriteLine(unsplitedData);
            }obj4.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
