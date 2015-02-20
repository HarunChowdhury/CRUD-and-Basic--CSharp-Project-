using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerComplainUI
{
    public partial class CustomerComplainUI : Form
    {
        public CustomerComplainUI()
        {
            InitializeComponent();
        }


        private Queue<Customer> myCustomer = new Queue<Customer>();
        private ListViewItem customerDetailsList;
        private int serialCount = 1;

        private void enqueueButton_Click(object sender, EventArgs e)
        {

            Customer aCustomerList = new Customer();
            aCustomerList.serialNo = serialCount;
            aCustomerList.name = nameEnqueueTextBox.Text;
            aCustomerList.complain = complainEnqueueTextBox.Text;
            myCustomer.Enqueue(aCustomerList);

            customerDetailsList = new ListViewItem();
            customerDetailsList.Text = aCustomerList.serialNo.ToString();
            customerDetailsList.SubItems.Add(aCustomerList.name);
            customerDetailsList.SubItems.Add(aCustomerList.complain);
            waitingQueueListView.Items.Add(customerDetailsList);
            MessageBox.Show(aCustomerList.name + ",s serial number is " + aCustomerList.serialNo);
            serialCount++;
            nameEnqueueTextBox.Text = "";
            complainEnqueueTextBox.Text = "";
        }

        private void deQueueButton_Click(object sender, EventArgs e)
        {
            
            Customer deQueueCustomerList = new Customer();
            if (myCustomer.Count==0)
            {
                MessageBox.Show("Queue is Empty");
            }
            else
            {
                deQueueCustomerList = myCustomer.Dequeue();
                serialNoDequeueTextBox.Text = deQueueCustomerList.serialNo.ToString();
                nameDequeueTextBox.Text = deQueueCustomerList.name;
                complainDequeueTextBox.Text = deQueueCustomerList.complain;
                waitingQueueListView.Items[0].Remove();   
            }
           
           
        }
    }
}
