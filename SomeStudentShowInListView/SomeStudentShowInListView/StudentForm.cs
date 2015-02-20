using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeStudentShowInListView
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;
            int i = 0;
            ListViewItem item = new ListViewItem(name);  
            item.SubItems.Add(address); 
            item.SubItems.Add(phone);
            studentListView.Items.Add(item);

        }
    }
}
