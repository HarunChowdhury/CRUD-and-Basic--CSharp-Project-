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

namespace Daily_Expense
{
    public partial class DailyExpenseUI : Form
    {
        public DailyExpenseUI()
        {
            InitializeComponent();
        }

        private string fileLocation = @"C:\Users\HARUN Chowdhury\Desktop\Daily Expense(Harun)\Daily Expense\DailyExpense.csv";
        private int maximumExpense=0;
        private int amount=0;
        private int total = 0;
       
        private string catagory;
        private string particular;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "" || firstCatagoryComboBox1.Text == "" || particularTextBox.Text == "")
            {
                MessageBox.Show("First Entry Amount,Category and Particular Daily expense.");
            }
            else
            {
                List<string> aList = new List<string>();

                catagory = firstCatagoryComboBox1.Text;
                particular = particularTextBox.Text;
                amount = Convert.ToInt32(amountTextBox.Text);
                total = total + amount;
                maximumExpense = Math.Max(maximumExpense, amount);

                FileStream aStream = new FileStream(fileLocation, FileMode.Append);
                CsvFileWriter aCsvFileWriter = new CsvFileWriter(aStream);
                aList.Add(amount.ToString());
                aList.Add(catagory);
                aList.Add(particular);

                aCsvFileWriter.WriteRow(aList);
                MessageBox.Show("Entry Successfull");
                aStream.Close();
                amountTextBox.Text = "";
                particularTextBox.Text = "";
            }
        }

        private void showViewSummaryButton_Click(object sender, EventArgs e)
        {
            totalExpenseTextBox.Text = Convert.ToString(total);
            maximumExpenseTextBox.Text = Convert.ToString(maximumExpense);
            amountTextBox.Text = "";
            firstCatagoryComboBox1.Text = "";
            particularTextBox.Text = "";
            showListView.Items.Clear();
        }

        private void showCatagoryWiseExpenseButton_Click(object sender, EventArgs e)
        {
              showListView.Items.Clear();        
            int catagoryWiseTotal = 0;
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> aList = new List<string>();
            ListViewItem item;
           


                while (aReader.ReadRow(aList))
                {
                    if (aList[1] == secondCatagoryComboBox2.Text)
                    {
                        item = new ListViewItem(aList[0].ToString());
                        item.SubItems.Add(aList[1]);
                        item.SubItems.Add(aList[2]);
                        showListView.Items.Add(item);
                        catagoryWiseTotal = catagoryWiseTotal + Convert.ToInt32(aList[0]);
                    }

                }
           

            totalCatagoryWiseExpenseTextBox.Text = Convert.ToString(catagoryWiseTotal);

            aFileStream.Close();
           
        }
    }
}
