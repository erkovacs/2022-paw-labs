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
using System.Xml.Serialization;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private List<Person> persons;

        private void ListPersons()
        {
            dgvPersons.Rows.Clear();
            foreach (Person p in persons)
            {
                int id = dgvPersons.Rows.Add(new object[] { p.Ssn, p.LastName, p.FirstName });
                dgvPersons.Rows[id].Tag = p;
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
            saveFileDialog.Filter = "Binary File | *.bin | XML file | *.xml | CSV File | *.csv";
            saveFileDialog.Title = "Save as a file";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith(".bin"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = File.Create(saveFileDialog.FileName))
                        formatter.Serialize(stream, persons);
                    console.Text += "Contents saved to file " + saveFileDialog.FileName + Environment.NewLine;
                }
                else if (saveFileDialog.FileName.EndsWith(".xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                    using (FileStream stream = File.Create(saveFileDialog.FileName))
                        serializer.Serialize(stream, persons);
                    console.Text += "Contents saved to file " + saveFileDialog.FileName + Environment.NewLine;
                }
                else 
                {
                    var csv = "Ssn,FirstName,LastName,BirthDate,Gender\n";
                    foreach (Person person in persons)
                    {
                        csv += $"{person.Ssn},{person.FirstName},{person.LastName},{person.BirthDate},{person.Gender}\n";
                    }

                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    { 
                        sw.Write(csv);
                        console.Text += "Contents saved to file " + saveFileDialog.FileName + Environment.NewLine;
                    }
                }

            }
        }

        private void readFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary File | *.bin | XML file | *.xml";
            openFileDialog.Title = "Read from file";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".bin"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = File.OpenRead(openFileDialog.FileName))
                        persons = (List<Person>)formatter.Deserialize(stream);
                        console.Text += "Contents restored from file " + openFileDialog.FileName + Environment.NewLine;
                }
                else if (openFileDialog.FileName.EndsWith(".xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
                    using (FileStream stream = File.OpenRead(openFileDialog.FileName))
                        persons = (List<Person>)xmlSerializer.Deserialize(stream);
                        console.Text += "Contents restored from file " + openFileDialog.FileName + Environment.NewLine;
                }
                else
                {
                    MessageBox.Show("No file chosen!", "No file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ListPersons();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dgvPersons.SelectedRows.Count > 0)
            {
                var person = (Person)dgvPersons.SelectedRows[0].Tag;

                EditForm ef = new EditForm(person);
                if (ef.ShowDialog() == DialogResult.OK)
                {
                    console.Text = "User was updated";
                    ListPersons();
                }
            }
        }
    }
}
