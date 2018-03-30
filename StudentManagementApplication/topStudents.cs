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
    public partial class topStudents : Form
    {
        public topStudents()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float max = 0;
            float secondMax = 0;
            float thirdMax = 0;
            string fileData;
            StreamReader obj = new StreamReader("Data.txt");
            string[] fileInput = new string[6];
            float num;
            string[] displayMaxData = new String[3];
            string[] displaysecondMaxData = new String[3];
            string[] displaythirdMaxData = new String[3];
            while ((fileData = obj.ReadLine()) != null)
            {
                fileInput = fileData.Split(';');
                string GPA = fileInput[3];
                num = float.Parse(GPA);
                if (num > max)
                {
                    max = num;
                    displayMaxData[0] = fileInput[0];
                    displayMaxData[1] = fileInput[1];
                    displayMaxData[2] = fileInput[3];
                }

            }
            obj.Close();

            StreamReader obj1 = new StreamReader("Data.txt");
            while ((fileData = obj1.ReadLine()) != null)
            {
                fileInput = fileData.Split(';');
                string GPA = fileInput[3];
                num = float.Parse(GPA);
                if (num > secondMax && num < max)
                {
                    secondMax = num;
                    displaysecondMaxData[0] = fileInput[0];
                    displaysecondMaxData[1] = fileInput[1];
                    displaysecondMaxData[2] = fileInput[3];

                }

            }
            obj.Close();
            StreamReader obj2 = new StreamReader("Data.txt");
            while ((fileData = obj2.ReadLine()) != null)
            {
                string GPA = fileInput[3];
                num = float.Parse(GPA);
                if (num > thirdMax && num < secondMax)
                {
                    thirdMax = num;
                    Console.WriteLine(thirdMax);
                    displaythirdMaxData[0] = fileInput[0];
                    displaythirdMaxData[1] = fileInput[1];
                    displaythirdMaxData[2] = fileInput[3];

                }

            }
            obj.Close();
            ListViewItem list = new ListViewItem(displayMaxData[0]);
            list.SubItems.Add(displayMaxData[1]);
            list.SubItems.Add(displayMaxData[2]);
            
            //Console.WriteLine("ID= " + displayMaxData[0]);
            //Console.WriteLine("Name= " + displayMaxData[1]);
            //Console.WriteLine("GPA= " + displayMaxData[2]);
            //Console.WriteLine("ID= " + displaysecondMaxData[0]);
            //Console.WriteLine("Name= " + displaysecondMaxData[1]);
            //Console.WriteLine("GPA= " + displaysecondMaxData[2]);
            //Console.WriteLine("ID= " + displaythirdMaxData[0]);
            //Console.WriteLine("Name= " + displaythirdMaxData[1]);
            //Console.WriteLine("GPA= " + displaythirdMaxData[2]);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
