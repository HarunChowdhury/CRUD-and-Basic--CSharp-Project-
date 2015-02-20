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
using CSVLib;

namespace AddressBook
{
    public partial class AddressBookUI : Form
    {
        public AddressBookUI()
        {
            InitializeComponent();
        }

        private string fileLocation = @"C:\Users\cse\Desktop\AddressBook(Harun)\personInfo.csv";   
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            string personName = nameTextBox.Text;
            string email = emailTextBox.Text;
            string personContact = personalContactTextBox.Text;
            string homeContact = homeContactTextBox.Text;
            string address = homeAddressTextBox.Text;

            FileStream aFileStreamReader = new FileStream(fileLocation, FileMode.OpenOrCreate);
            CsvFileReader aCsvFileReader=new CsvFileReader(aFileStreamReader);
            List<string> aRecord = new List<string>();
              while (aCsvFileReader.ReadRow(aRecord))
                  {
                     

                      if (aRecord[2] == personalContactTextBox.Text)
                      {
                          MessageBox.Show("This Phone Contact is Already exists.");
                          aFileStreamReader.Close();
                          return;
                      }
                  }
            MessageBox.Show("Save successfull...");  
               
                 aFileStreamReader.Close();

                 FileStream aFileStreaWriter= new FileStream(fileLocation, FileMode.Append);
                 CsvFileWriter aCsvFileWriter=new CsvFileWriter(aFileStreaWriter);
                 List<string> aStudentRecord = new List<string>();

                aStudentRecord.Add(personName);
                aStudentRecord.Add(email);
                aStudentRecord.Add(personContact);
                aStudentRecord.Add(homeContact);
                aStudentRecord.Add(address);
                aCsvFileWriter.WriteRow(aStudentRecord);
                
                aFileStreaWriter.Close();

                nameTextBox.Text=string.Empty;
                emailTextBox.Text=string.Empty;
                personalContactTextBox.Text=string.Empty;
                homeContactTextBox.Text=string.Empty;
               homeAddressTextBox.Text=string.Empty; 

        }
      

        private void showButton_Click_1(object sender, EventArgs e)
        {
            allInfoListView.Items.Clear();
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aStudentRecord = new List<string>();
            ListViewItem list;
            while (aReader.ReadRow(aStudentRecord))
            {
                list = new ListViewItem(aStudentRecord[0]);

                list.SubItems.Add(aStudentRecord[1]);
                list.SubItems.Add(aStudentRecord[2]);
                list.SubItems.Add(aStudentRecord[3]);
                list.SubItems.Add(aStudentRecord[4]);
                allInfoListView.Items.Add(list);
            }

            aStream.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            allInfoListView.Items.Clear();
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aStudentRecord = new List<string>();
            ListViewItem list;
            while (aReader.ReadRow(aStudentRecord))
            {
                if (aStudentRecord[1] == searchTextBox.Text || aStudentRecord[2] == searchTextBox.Text || aStudentRecord[4] == searchTextBox.Text)
                {
                    list = new ListViewItem(aStudentRecord[0]);

                    list.SubItems.Add(aStudentRecord[1]);
                    list.SubItems.Add(aStudentRecord[2]);
                    list.SubItems.Add(aStudentRecord[3]);
                    list.SubItems.Add(aStudentRecord[4]);
                    allInfoListView.Items.Add(list);
                }
                else
                {
                    MessageBox.Show("No Match");
                }
            }

            aStream.Close();
        }
    }
}
