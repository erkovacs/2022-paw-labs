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
    public partial class EditForm : Form
    {
        private Person _person;
        public EditForm(Person person)
        {
            _person = person;
            InitializeComponent();
            lastName.Text = _person.LastName;
            firstName.Text = _person.FirstName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _person.LastName = lastName.Text;
            _person.FirstName = firstName.Text;
        }
    }
}
