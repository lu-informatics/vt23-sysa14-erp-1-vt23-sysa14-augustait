namespace ERPApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FindEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxNbr = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.FindEmployee);
            this.tabPage1.Controls.Add(this.AddEmployee);
            this.tabPage1.Controls.Add(this.textBoxCity);
            this.tabPage1.Controls.Add(this.textBoxJobTitle);
            this.tabPage1.Controls.Add(this.textBoxNbr);
            this.tabPage1.Controls.Add(this.textBoxLastName);
            this.tabPage1.Controls.Add(this.textBoxFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(891, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(35, 27);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(824, 226);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(743, 507);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 31);
            this.button8.TabIndex = 12;
            this.button8.Text = "All Primary Keys";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AllPrimaryKeys_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(526, 507);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(195, 31);
            this.button7.TabIndex = 11;
            this.button7.Text = "Total Number Of Columns";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.TotalNumberOfColumns);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(307, 507);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 31);
            this.button6.TabIndex = 10;
            this.button6.Text = "Total Number Of Tables";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.TotalNumberOfTables_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 507);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Names Of All Columns";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NamesOfAllColumns_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 456);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 507);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FindEmployee
            // 
            this.FindEmployee.Location = new System.Drawing.Point(8, 405);
            this.FindEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindEmployee.Name = "FindEmployee";
            this.FindEmployee.Size = new System.Drawing.Size(86, 31);
            this.FindEmployee.TabIndex = 6;
            this.FindEmployee.Text = "Find";
            this.FindEmployee.UseVisualStyleBackColor = true;
           // this.FindEmployee.Click += new System.EventHandler(this.FindEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(8, 355);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(86, 31);
            this.AddEmployee.TabIndex = 5;
            this.AddEmployee.Text = "Create";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.CreateEmployee_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(745, 296);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.PlaceholderText = "City:";
            this.textBoxCity.Size = new System.Drawing.Size(114, 27);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(557, 296);
            this.textBoxJobTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.PlaceholderText = "Job Title:";
            this.textBoxJobTitle.Size = new System.Drawing.Size(114, 27);
            this.textBoxJobTitle.TabIndex = 3;
            // 
            // textBoxNbr
            // 
            this.textBoxNbr.Location = new System.Drawing.Point(8, 296);
            this.textBoxNbr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNbr.Name = "textBoxNbr";
            this.textBoxNbr.PlaceholderText = "ID:";
            this.textBoxNbr.Size = new System.Drawing.Size(114, 27);
            this.textBoxNbr.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(363, 296);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.PlaceholderText = "Last Name";
            this.textBoxLastName.Size = new System.Drawing.Size(114, 27);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(189, 296);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.PlaceholderText = "First name:";
            this.textBoxFirstName.Size = new System.Drawing.Size(114, 27);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "CRONUS Sverige AB";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private Button button4;
        private Button button3;
        private Button FindEmployee;
        private Button AddEmployee;
        private TextBox textBoxCity;
        private TextBox textBoxJobTitle;
        private TextBox textBoxNbr;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TabControl tabControl1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private RichTextBox richTextBox;
    }
}