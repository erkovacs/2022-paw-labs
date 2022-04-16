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
            firstName.Text = _person.FirstName;
            lastName.Text = _person.LastName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _person.FirstName = firstName.Text;
            _person.LastName = lastName.Text;
        }
    }
}
