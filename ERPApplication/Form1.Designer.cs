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
            this.labelDataBaseName = new System.Windows.Forms.Label();
            this.comboBoxEmpId = new System.Windows.Forms.ComboBox();
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
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.labelDataBaseName);
            this.tabPage1.Controls.Add(this.comboBoxEmpId);
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
            this.tabPage1.Controls.Add(this.textBoxLastName);
            this.tabPage1.Controls.Add(this.textBoxFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            // 
            // labelDataBaseName
            // 
            this.labelDataBaseName.AutoSize = true;
            this.labelDataBaseName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataBaseName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDataBaseName.Location = new System.Drawing.Point(200, 3);
            this.labelDataBaseName.Name = "labelDataBaseName";
            this.labelDataBaseName.Size = new System.Drawing.Size(354, 47);
            this.labelDataBaseName.TabIndex = 25;
            this.labelDataBaseName.Text = "CRONUS Sverige AB";
            // 
            // comboBoxEmpId
            // 
            this.comboBoxEmpId.FormattingEnabled = true;
            this.comboBoxEmpId.Location = new System.Drawing.Point(7, 222);
            this.comboBoxEmpId.Name = "comboBoxEmpId";
            this.comboBoxEmpId.Size = new System.Drawing.Size(100, 23);
            this.comboBoxEmpId.TabIndex = 14;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(7, 56);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(766, 137);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(650, 380);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "All Primary Keys";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AllPrimaryKeys_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(460, 380);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Total Number Of Columns";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.TotalNumberOfColumns);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(269, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Total Number Of Tables";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.TotalNumberOfTables_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(104, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Names Of All Columns";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NamesOfAllColumns_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // FindEmployee
            // 
            this.FindEmployee.Location = new System.Drawing.Point(7, 304);
            this.FindEmployee.Name = "FindEmployee";
            this.FindEmployee.Size = new System.Drawing.Size(75, 23);
            this.FindEmployee.TabIndex = 6;
            this.FindEmployee.Text = "Find";
            this.FindEmployee.UseVisualStyleBackColor = true;
            this.FindEmployee.Click += new System.EventHandler(this.FindEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(7, 266);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(75, 23);
            this.AddEmployee.TabIndex = 5;
            this.AddEmployee.Text = "Create";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.CreateEmployee_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(652, 222);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.PlaceholderText = "City:";
            this.textBoxCity.Size = new System.Drawing.Size(100, 23);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(487, 222);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.PlaceholderText = "Job Title:";
            this.textBoxJobTitle.Size = new System.Drawing.Size(100, 23);
            this.textBoxJobTitle.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(318, 222);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.PlaceholderText = "Last Name";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(165, 222);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.PlaceholderText = "First name:";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TabControl tabControl1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private RichTextBox richTextBox;
        private ComboBox comboBoxEmpId;
        private Label labelDataBaseName;
    }
}