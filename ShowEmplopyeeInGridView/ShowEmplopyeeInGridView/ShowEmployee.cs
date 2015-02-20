using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowEmplopyeeInGridView
{
    public partial class ShowEmployee : Form
    {
        public ShowEmployee()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;

            Employee aEmployee = new Employee(name, address, phone);
            List<Employee> employees = aEmployee.SavEmployees(aEmployee);
            dataGridView1.DataSource = employees;    
        }
    }
}
