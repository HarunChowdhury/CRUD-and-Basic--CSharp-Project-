namespace Daily_Expense
{
    partial class DailyExpenseUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.firstCatagoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.showListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalCatagoryWiseExpenseTextBox = new System.Windows.Forms.TextBox();
            this.showCatagoryWiseExpenseButton = new System.Windows.Forms.Button();
            this.secondCatagoryComboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.showViewSummaryButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Expense Entry";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(106, 32);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(148, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(179, 115);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // firstCatagoryComboBox1
            // 
            this.firstCatagoryComboBox1.FormattingEnabled = true;
            this.firstCatagoryComboBox1.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.firstCatagoryComboBox1.Location = new System.Drawing.Point(106, 59);
            this.firstCatagoryComboBox1.Name = "firstCatagoryComboBox1";
            this.firstCatagoryComboBox1.Size = new System.Drawing.Size(148, 21);
            this.firstCatagoryComboBox1.TabIndex = 3;
            // 
            // showListView
            // 
            this.showListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.showListView.GridLines = true;
            this.showListView.Location = new System.Drawing.Point(304, 115);
            this.showListView.Name = "showListView";
            this.showListView.Size = new System.Drawing.Size(303, 172);
            this.showListView.TabIndex = 4;
            this.showListView.UseCompatibleStateImageBehavior = false;
            this.showListView.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Particular";
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(106, 89);
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(148, 20);
            this.particularTextBox.TabIndex = 1;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(106, 221);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(148, 20);
            this.totalExpenseTextBox.TabIndex = 1;
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(106, 249);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(148, 20);
            this.maximumExpenseTextBox.TabIndex = 1;
            // 
            // totalCatagoryWiseExpenseTextBox
            // 
            this.totalCatagoryWiseExpenseTextBox.Location = new System.Drawing.Point(511, 307);
            this.totalCatagoryWiseExpenseTextBox.Name = "totalCatagoryWiseExpenseTextBox";
            this.totalCatagoryWiseExpenseTextBox.Size = new System.Drawing.Size(96, 20);
            this.totalCatagoryWiseExpenseTextBox.TabIndex = 1;
            // 
            // showCatagoryWiseExpenseButton
            // 
            this.showCatagoryWiseExpenseButton.Location = new System.Drawing.Point(532, 75);
            this.showCatagoryWiseExpenseButton.Name = "showCatagoryWiseExpenseButton";
            this.showCatagoryWiseExpenseButton.Size = new System.Drawing.Size(75, 34);
            this.showCatagoryWiseExpenseButton.TabIndex = 2;
            this.showCatagoryWiseExpenseButton.Text = "Show";
            this.showCatagoryWiseExpenseButton.UseVisualStyleBackColor = true;
            this.showCatagoryWiseExpenseButton.Click += new System.EventHandler(this.showCatagoryWiseExpenseButton_Click);
            // 
            // secondCatagoryComboBox2
            // 
            this.secondCatagoryComboBox2.FormattingEnabled = true;
            this.secondCatagoryComboBox2.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.secondCatagoryComboBox2.Location = new System.Drawing.Point(463, 31);
            this.secondCatagoryComboBox2.Name = "secondCatagoryComboBox2";
            this.secondCatagoryComboBox2.Size = new System.Drawing.Size(148, 21);
            this.secondCatagoryComboBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "View Catagorywise Expense";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Catagory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Maximum Expense";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "View Summary";
            // 
            // showViewSummaryButton
            // 
            this.showViewSummaryButton.Location = new System.Drawing.Point(170, 180);
            this.showViewSummaryButton.Name = "showViewSummaryButton";
            this.showViewSummaryButton.Size = new System.Drawing.Size(75, 30);
            this.showViewSummaryButton.TabIndex = 11;
            this.showViewSummaryButton.Text = "Show";
            this.showViewSummaryButton.UseVisualStyleBackColor = true;
            this.showViewSummaryButton.Click += new System.EventHandler(this.showViewSummaryButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Particular";
            this.columnHeader3.Width = 150;
            // 
            // DailyExpenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.showViewSummaryButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showListView);
            this.Controls.Add(this.secondCatagoryComboBox2);
            this.Controls.Add(this.firstCatagoryComboBox1);
            this.Controls.Add(this.showCatagoryWiseExpenseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalCatagoryWiseExpenseTextBox);
            this.Controls.Add(this.maximumExpenseTextBox);
            this.Controls.Add(this.totalExpenseTextBox);
            this.Controls.Add(this.particularTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DailyExpenseUI";
            this.Text = "Daily Expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox firstCatagoryComboBox1;
        private System.Windows.Forms.ListView showListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.TextBox totalCatagoryWiseExpenseTextBox;
        private System.Windows.Forms.Button showCatagoryWiseExpenseButton;
        private System.Windows.Forms.ComboBox secondCatagoryComboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button showViewSummaryButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

