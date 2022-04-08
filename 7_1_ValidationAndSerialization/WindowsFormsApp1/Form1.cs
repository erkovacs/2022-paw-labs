using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private List<Person> persons;

        private void ListPersons()
        {
            console.Text = "";

            foreach (var person in persons)
            {
                console.Text += person + Environment.NewLine;
            }
        }

        public Form1()
        {
            persons = new List<Person>();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gender gender = Gender.NA;
            if (male.Checked)
            {
                gender = Gender.Male;
            }
            if (female.Checked)
            {
                gender = Gender.Female;
            }

            try
            {
                var error = errorProvider1.GetError(ssn);
                if (!("".Equals(error)))
                {
                    throw new Exception("SSN must not be null or empty.");
                }

                var found = persons.Find(p => p.Ssn.Equals(ssn.Text));
                if (found != null)
                {
                    throw new Exception("SSN must be unique.");
                }

                persons.Add(new Person(lastName.Text, firstName.Text, ssn.Text,
                    birthDate.Value, gender));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListPersons();
        }

        private void ssn_Validating(object sender, CancelEventArgs e)
        {
            var control = (Control)sender;
            var value = control.Text;

            if (string.IsNullOrEmpty(value))
            {
                errorProvider1.SetError(control, "SSN must not be null or empty.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void saveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.bin";
            saveFileDialog.Title = "Save as a binary file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                    formatter.Serialize(stream, persons);

                console.Text += "Contents saved to file " + saveFileDialog.FileName + Environment.NewLine;
            }
        }
    }
}
