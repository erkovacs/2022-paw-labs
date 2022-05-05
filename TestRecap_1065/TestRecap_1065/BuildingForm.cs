using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestRecap_1065.Entities;

namespace TestRecap_1065
{
    public partial class BuildingForm : Form
    {

        private Building Building;

        public BuildingForm()
        {
            InitializeComponent();
            Building = new Building();
        }

        private void DisplayRooms()
        {
            Building.Rooms.Sort();
            dgvRooms.Rows.Clear();
            foreach (Room room in Building.Rooms)
            {
                int index = dgvRooms.Rows.Add(new object [] { room.Id, room.Name, room.HasProjector  });
                dgvRooms.Rows[index].Tag = room;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            bool isNewRoom = true;
            Room room = new Room(0, string.Empty, false);

            if (dgvRooms.SelectedRows.Count > 0)
            {
                room = dgvRooms.SelectedRows[0].Tag as Room;
                isNewRoom = false;
            }

            Form form = new RoomForm(room);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (isNewRoom)
                { 
                    Building.Rooms.Add(room);
                }
                DisplayRooms();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(
                    "Delete confirmation", 
                    "Are you sure you want to delete this room?", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                
                    var room = dgvRooms.SelectedRows[0].Tag as Room;
                    Building.Rooms.Remove(room);
                    DisplayRooms();
                }
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(dialog.FileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Building));
                    serializer.Serialize(fs, Building);
                }
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // dialog.Filter = "*.xml | XML Files";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(dialog.FileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Building));
                    Building = serializer.Deserialize(fs) as Building;
                    DisplayRooms();
                }
            }
        }
    }
}
