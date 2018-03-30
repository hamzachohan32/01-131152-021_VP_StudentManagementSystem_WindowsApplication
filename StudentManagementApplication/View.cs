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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unsplitedData;
            string[] splitedData = new string[7];
            StreamReader obj = new StreamReader("Attendance.txt");
            while ((unsplitedData = obj.ReadLine()) != null)
            {
                splitedData = unsplitedData.Split(';');
                ListViewItem list = new ListViewItem(splitedData[0]);
                list.SubItems.Add(splitedData[1]);
                list.SubItems.Add(splitedData[6]);
                listView1.Items.Add(list);
            }
        }
    }
}
