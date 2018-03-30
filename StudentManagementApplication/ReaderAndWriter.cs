using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApplication
{
    class ReaderAndWriter
    {
        public string[] fileReader()

        {
            int length = 0;
            String fileInput;
            StreamReader obj1 = new StreamReader("Data.txt");
            while ((obj1.ReadLine()) != null)
            {
                length++;
            }
            length = length * 6;

            string[] tempData = new string[6];
            string[] fileData = new string[length];

            int i = 0;

            while ((fileInput = obj1.ReadLine()) != null)
            {
                tempData=fileInput.Split(';');
                
                for(int j=0;j<6;j++)
                {
                    
                    fileData[i] = tempData[j];
                    
                    i++;
                }
            }
            
            obj1.Close();
            return fileData;
        }
        public void filewriter(string[] Data)
        {
            StreamWriter obj = File.AppendText("Data.txt");
            obj.AutoFlush = true;
            obj.Write(Data[0] + ";" + Data[1] + ";" + Data[2] + ";" + Data[3] + ";" + Data[4] + ";" + Data[5]);
                obj.WriteLine();
                obj.Close();
                MessageBox.Show("Success");
            
        }
    }
}