using _1066_6_1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1066_6_1
{
    public partial class EditForm : Form
    {
        private Person _person;
        public EditForm(Person person)
        {
            _person = person;
            InitializeComponent();
            ssn.Text = _person.Ssn;
            lastName.Text = _person.LastName;
            firstName.Text = _person.FirstName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _person.Ssn = ssn.Text;
            _person.LastName = lastName.Text;
            _person.FirstName = firstName.Text;
        }
    }
}
