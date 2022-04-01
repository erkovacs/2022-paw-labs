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
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(113, 32);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(200, 20);
            this.lastName.TabIndex = 0;
            this.lastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(113, 71);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 20);
            this.firstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth date";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(113, 113);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 20);
            this.birthDate.TabIndex = 5;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(540, 33);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(631, 33);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SSN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(540, 71);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(200, 20);
            this.ssn.TabIndex = 10;
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.console.ForeColor = System.Drawing.Color.Lime;
            this.console.Location = new System.Drawing.Point(52, 162);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(688, 260);
            this.console.TabIndex = 11;
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(597, 114);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(75, 23);
            this.addPerson.TabIndex = 12;
            this.addPerson.Text = "Add Person";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 454);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

