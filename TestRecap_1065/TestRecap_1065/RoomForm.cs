using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRecap_1065.Entities;

namespace TestRecap_1065
{
    public partial class RoomForm : Form
    {
        private Room Room;
        public RoomForm()
        {
            InitializeComponent();
        }

        public RoomForm(Room room) : this()
        {
            Room = room;
            ctrlId.Value = room.Id;
            ctrlName.Text = room.Name;
            ctrlHasProjector.Checked = room.HasProjector;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(ctrlId) == string.Empty)
            {
                Room.Id = (int)ctrlId.Value;
                Room.Name = ctrlName.Text;
                Room.HasProjector = ctrlHasProjector.Checked;
            } 
            else 
            {
                MessageBox.Show(
                    "Errors in form", 
                    "Your form contains errors", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void ctrlId_Validating(object sender, CancelEventArgs e)
        {
            if (ctrlId.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ctrlId, "ID cannot be 0!");
            }
            else 
            {
                errorProvider1.Clear();
            }
        }
    }
}
