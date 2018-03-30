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
    public partial class MarkAttandence : Form
    {
        private int length;
        ComboBox[] rb = new ComboBox[100];
        public MarkAttandence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader obj = new StreamReader("Data.txt");
            string unsplitedData=null;
            string[] splitedData = new string[6];
            StreamWriter obj1 = new StreamWriter("Attendance.txt");
            while ((unsplitedData=obj.ReadLine())!=null)
            {
                splitedData = unsplitedData.Split(';');
                if ((splitedData[3].Trim()) == comboSemester.Text.Trim())
                {
                    ListViewItem list = new ListViewItem(splitedData[0]);
                    list.SubItems.Add(splitedData[1]);
                    listView1.Items.Add(list);
                    length++;
                    obj1.WriteLine(unsplitedData);
                    
                }

            }
            obj.Close();
            obj1.Close();
            
            for (int i = 0; i < length; i++)
            {
                rb[i] = new ComboBox();
                rb[i].Location = new Point(0, i * 20);
                rb[i].Items.Add("Present");
                rb[i].Items.Add("Absent");
                panel1.Controls.Add(rb[i]);
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            StreamReader obj2 = new StreamReader("Attendance.txt");
            
            string[] unsplitedData= new string[length];
            for (int i = 0; i < length; i++)
            {
                unsplitedData[i] = obj2.ReadLine();
                unsplitedData[i] = unsplitedData[i] + ';' + rb[i].Text.ToString();
            }
            obj2.Close();
            StreamWriter obj1 = new StreamWriter("Attendance.txt");
            for (int i = 0; i < length; i++)
            {
                obj1.WriteLine(unsplitedData[i]);
            }
            obj1.Close();
            MessageBox.Show("Saved");

        }

        private void View_Click(object sender, EventArgs e)
        {
            View obj = new View();
            obj.Show();
            this.Hide();
        }
    }
}
