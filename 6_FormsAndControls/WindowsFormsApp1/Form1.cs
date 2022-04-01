using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Gender gender = male.Checked ? Gender.Male : Gender.Female;

            persons.Add(new Person(lastName.Text, firstName.Text, ssn.Text, 
                DateTime.Now, gender));
            ListPersons();
        }


    }
}
