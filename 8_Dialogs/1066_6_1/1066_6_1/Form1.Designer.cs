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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.ssnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formValidationErrrorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // dgvPersons
            // 
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnCol,
            this.lastNameCol,
            this.firstNameCol});
            this.dgvPersons.Location = new System.Drawing.Point(26, 231);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 29;
            this.dgvPersons.Size = new System.Drawing.Size(740, 188);
            this.dgvPersons.TabIndex = 16;
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
            this.lastNameCol.HeaderText = "Last name";
            this.lastNameCol.MinimumWidth = 6;
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Width = 125;
            // 
            // firstNameCol
            // 
            this.firstNameCol.HeaderText = "First name";
            this.firstNameCol.MinimumWidth = 6;
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.Width = 125;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(672, 427);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Add/Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(563, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvPersons);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.formValidationErrrorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private DataGridView dgvPersons;
        private DataGridViewTextBoxColumn ssnCol;
        private DataGridViewTextBoxColumn lastNameCol;
        private DataGridViewTextBoxColumn firstNameCol;
        private Button btnEdit;
        private Button btnDelete;
    }
}