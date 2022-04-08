namespace _1066_6_1
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
            this.components = new System.ComponentModel.Container();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.myConsole = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.formValidationErrrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.formValidationErrrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(109, 44);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(250, 27);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            this.firstName.Validating += new System.ComponentModel.CancelEventHandler(this.firstName_Validating);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(109, 102);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(250, 27);
            this.lastName.TabIndex = 1;
            this.lastName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            this.lastName.Validating += new System.ComponentModel.CancelEventHandler(this.lastName_Validating);
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(515, 106);
            this.ssn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(251, 27);
            this.ssn.TabIndex = 2;
            this.ssn.Validating += new System.ComponentModel.CancelEventHandler(this.ssn_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SSN";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(106, 170);
            this.birthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(250, 27);
            this.birthDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birth date";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(534, 46);
            this.male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(63, 24);
            this.male.TabIndex = 8;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(619, 46);
            this.female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(78, 24);
            this.female.TabIndex = 9;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // myConsole
            // 
            this.myConsole.BackColor = System.Drawing.SystemColors.MenuText;
            this.myConsole.ForeColor = System.Drawing.Color.Lime;
            this.myConsole.Location = new System.Drawing.Point(26, 461);
            this.myConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myConsole.Multiline = true;
            this.myConsole.Name = "myConsole";
            this.myConsole.ReadOnly = true;
            this.myConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myConsole.Size = new System.Drawing.Size(740, 65);
            this.myConsole.TabIndex = 11;
            this.myConsole.TextChanged += new System.EventHandler(this.myConsole_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formValidationErrrorProvider
            // 
            this.formValidationErrrorProvider.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(26, 237);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 209);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myConsole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.formValidationErrrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstName;
        private TextBox lastName;
        private TextBox ssn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker birthDate;
        private RadioButton male;
        private RadioButton female;
        private Label label5;
        private TextBox myConsole;
        private Button button1;
        private ErrorProvider formValidationErrrorProvider;
        private Button button2;
        private ListView listView1;
    }
}