using _1066_6_1.Entities;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _1066_6_1
{
    public partial class Form1 : Form
    {
        List<Person> persons;

        public Form1()
        {
            persons = new List<Person>();
            InitializeComponent();
        }

        public void ListPersons()
        {
            persons.Sort();

            dgvPersons.Rows.Clear();

            foreach (var person in persons)
            {
                int id = dgvPersons.Rows.Add(new object[] { person.Ssn, person.LastName, person.FirstName });
                dgvPersons.Rows[id].Tag = person;
            }
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gender gender = Gender.None;
            if (male.Checked)
            {
                gender = Gender.Male;
            }
            if (female.Checked)
            {
                gender = Gender.Female;
            }

            var person = new Person(lastName.Text, firstName.Text, ssn.Text,
                birthDate.Value, gender);

            if (
                (!"".Equals(formValidationErrrorProvider.GetError(lastName)) ||
                !"".Equals(formValidationErrrorProvider.GetError(firstName))) &&
                (!"".Equals(formValidationErrrorProvider.GetError(ssn)))
                )
            {
                MessageBox.Show("Form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var found = persons.Find(p => p.Ssn.Equals(person.Ssn));
            if (found == null)
            {
                persons.Add(person);
            }
            else
            {
                MessageBox.Show("User already added!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            ListPersons();
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstName.Text))
            {
                formValidationErrrorProvider.SetError((Control)sender, "First name is mandatory!");
            }
            else
            {
                formValidationErrrorProvider.Clear();
            }
        }

        private void lastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(lastName.Text))
            {
                formValidationErrrorProvider.SetError((Control)sender, "Last name is mandatory!");
            }
            else
            {
                formValidationErrrorProvider.Clear();
            }
        }

        private void ssn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ssn.Text))
            {
                formValidationErrrorProvider.SetError((Control)sender, "SSN is mandatory!");
            }
            else
            {
                formValidationErrrorProvider.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool wasWritten = false;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary File | *.bin | XML File | *.xml | Text File | *.csv";
            saveFileDialog.Title = "Save as file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialog.FileName;

                if (fileName.EndsWith(".bin"))
                {
                    // Write to file
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = File.Create(fileName))
                    {
                        formatter.Serialize(stream, persons);
                        wasWritten = true;
                    }
                }
                else if (fileName.EndsWith(".xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

                    using (FileStream stream = File.Create(fileName))
                    {
                        serializer.Serialize(stream, persons);
                        wasWritten = true;
                    }
                }
                else if (fileName.EndsWith(".csv"))
                {
                    var csv = "LastName,FirstName,Ssn,BirthDate,Gender\n";
                    foreach (Person person in persons)
                    {
                        var row = $"{person.LastName},{person.FirstName},{person.Ssn},{person.BirthDate},{person.Gender}\n";
                        csv += row;
                    }
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        sw.Write(csv);
                        wasWritten = true;
                    }
                }
                if (wasWritten) myConsole.Text += $"File saved to {saveFileDialog.FileName}.\n";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var person = ((ListView)sender).SelectedItems[0];
            MessageBox.Show(person.ToString(),
                    "Person",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void myConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool isNewPerson = false;
            Person person;

            if (dgvPersons.SelectedRows.Count == 0)
            {
                isNewPerson = true;
                person = new Person();
            }
            else
            { 
                person = dgvPersons.SelectedRows[0].Tag as Person;
            }

            EditForm dialog = new EditForm(person);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (isNewPerson) persons.Add(person);
                ListPersons();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Are you sure you want to delete the person?",
                    "Confirm delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var person = dgvPersons.SelectedRows[0].Tag as Person;
                persons.Remove(person);
                ListPersons();
            }
        }
    }
}