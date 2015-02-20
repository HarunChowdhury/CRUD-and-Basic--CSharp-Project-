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

namespace ReadWriteFileUI
{
    public partial class Form1 : Form
    {
        private string fileLocation = @"C:\Users\PC21\Desktop\HW C#\studentNname.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(fileLocation,FileMode.Append);
            StreamWriter aStreamWriter=new StreamWriter(aFileStream);
            aStreamWriter.Write(nameTextBox.Text);
            aStreamWriter.WriteLine();
           aStreamWriter.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            nameListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string aLine = aStreamReader.ReadLine();
                nameListBox.Items.Add(aLine);

            }

            aStreamReader.Close();
        }
    }
}
