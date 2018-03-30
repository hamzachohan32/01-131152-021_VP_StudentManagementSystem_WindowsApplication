using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApplication
{
    class DuplicateCheck
    {
        public bool isDuplicate(string data)
        {
            bool val=false;
            StreamReader obj1 = new StreamReader("Data.txt");
            string filedata;
            
            string[] dataStore = new string[6];

            while ((filedata=obj1.ReadLine()) != null)
            {
                dataStore = filedata.Split(';');

                if (dataStore[0] == data)
                {
                   
                    val = true;
                }
            }
            obj1.Close();
            return val;
        }
    }
}