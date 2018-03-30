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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unsplitedData;
            string[] splitedData = new string[6];
            StreamReader obj = new StreamReader("Data.txt");
            StreamWriter obj1 = new StreamWriter("SearchData.txt");
            if (id.Checked)
            {
                while ((unsplitedData = obj.ReadLine()) != null)
                {
                    splitedData = unsplitedData.Split(';');
                    if ((splitedData[0].Trim()) == textBox1.Text.Trim())
                    {
                        ListViewItem list = new ListViewItem(splitedData[0]);
                        list.SubItems.Add(splitedData[1]);
                        list.SubItems.Add(splitedData[2]);
                        list.SubItems.Add(splitedData[3]);
                        list.SubItems.Add(splitedData[4]);
                        list.SubItems.Add(splitedData[5]);
                        listView1.Items.Add(list);
                    }
                }obj1.Close();
            }
            if (Name.Checked)
            {
                while ((unsplitedData = obj.ReadLine()) != null)
                {
                    splitedData = unsplitedData.Split(';');
                    if ((splitedData[0].Trim()) == textBox1.Text.Trim())
                    {
                        ListViewItem list = new ListViewItem(splitedData[0]);
                        list.SubItems.Add(splitedData[1]);
                        list.SubItems.Add(splitedData[2]);
                        list.SubItems.Add(splitedData[3]);
                        list.SubItems.Add(splitedData[4]);
                        list.SubItems.Add(splitedData[5]);
                        listView1.Items.Add(list);
                    }
                }
            }
            if (Semester.Checked)
            {
                while ((unsplitedData = obj.ReadLine()) != null)
                {
                    splitedData = unsplitedData.Split(';');
                    if ((splitedData[0].Trim()) == textBox1.Text.Trim())
                    {
                        ListViewItem list = new ListViewItem(splitedData[0]);
                        list.SubItems.Add(splitedData[1]);
                        list.SubItems.Add(splitedData[2]);
                        list.SubItems.Add(splitedData[3]);
                        list.SubItems.Add(splitedData[4]);
                        list.SubItems.Add(splitedData[5]);
                        listView1.Items.Add(list);
                    }
                }
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
