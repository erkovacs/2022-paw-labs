namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ssn = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.TextBox();
            this.addPerson = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveToFile = new System.Windows.Forms.Button();
            this.readFromFile = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.ssnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(151, 39);
            this.lastName.Margin = new System.Windows.Forms.Padding(4);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(265, 22);
            this.lastName.TabIndex = 0;
            this.lastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(151, 87);
            this.firstName.Margin = new System.Windows.Forms.Padding(4);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(265, 22);
            this.firstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth date";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(151, 139);
            this.birthDate.Margin = new System.Windows.Forms.Padding(4);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(265, 22);
            this.birthDate.TabIndex = 5;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(720, 41);
            this.male.Margin = new System.Windows.Forms.Padding(4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(58, 20);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(841, 41);
            this.female.Margin = new System.Windows.Forms.Padding(4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(74, 20);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SSN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(720, 87);
            this.ssn.Margin = new System.Windows.Forms.Padding(4);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(265, 22);
            this.ssn.TabIndex = 10;
            this.ssn.Validating += new System.ComponentModel.CancelEventHandler(this.ssn_Validating);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.console.ForeColor = System.Drawing.Color.Lime;
            this.console.Location = new System.Drawing.Point(68, 615);
            this.console.Margin = new System.Windows.Forms.Padding(4);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(916, 93);
            this.console.TabIndex = 11;
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(798, 117);
            this.addPerson.Margin = new System.Windows.Forms.Padding(4);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(100, 28);
            this.addPerson.TabIndex = 12;
            this.addPerson.Text = "Add Person";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(798, 152);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(100, 23);
            this.saveToFile.TabIndex = 13;
            this.saveToFile.Text = "Save to file";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // readFromFile
            // 
            this.readFromFile.Location = new System.Drawing.Point(798, 187);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(147, 26);
            this.readFromFile.TabIndex = 14;
            this.readFromFile.Text = "Read from file";
            this.readFromFile.UseVisualStyleBackColor = true;
            this.readFromFile.Click += new System.EventHandler(this.readFromFile_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnCol,
            this.lastNameCol,
            this.firstNameCol});
            this.dgvPersons.Location = new System.Drawing.Point(68, 259);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 24;
            this.dgvPersons.Size = new System.Drawing.Size(877, 299);
            this.dgvPersons.TabIndex = 15;
            // 
            // ssnCol
            // 
            this.ssnCol.HeaderText = "SSN";
            this.ssnCol.MinimumWidth = 6;
            this.ssnCol.Name = "ssnCol";
            this.ssnCol.Width = 125;
            // 
            // lastNameCol
            // 
            this.lastNameCol.HeaderText = "Last Name";
            this.lastNameCol.MinimumWidth = 6;
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Width = 125;
            // 
            // firstNameCol
            // 
            this.firstNameCol.HeaderText = "First Name";
            this.firstNameCol.MinimumWidth = 6;
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.Width = 125;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(870, 574);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 16;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 736);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.console);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.female);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.male);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCol;
        private System.Windows.Forms.Button edit;
    }
}

