using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRecap.Entities;

namespace TestRecap
{
    public partial class AddEditForm : Form
    {
        private Aircraft _aircraft;
        public AddEditForm(Aircraft aircraft)
        {
            _aircraft = aircraft;
            InitializeComponent();
            numId.Value = _aircraft.Id;
            tbName.Text = _aircraft.Name;
        }

        private void numId_Validating(object sender, CancelEventArgs e)
        {
            if (numId.Value > 10000 || numId.Value <= 0)
            {
                errorProvider1.SetError((Control)sender, "Id must be between 1 and 9999");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProvider1.SetError((Control)sender, "Name must be a valid string!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _aircraft.Id = (int)numId.Value;
            _aircraft.Name = tbName.Text;
        }
    }
}
