using System.Xml.Serialization;
using TestRecap.Entities;

namespace TestRecap
{
    public partial class MainForm : Form
    {
        private Airfield _airfield;
        public MainForm()
        {
            _airfield = new Airfield(1);
            InitializeComponent();
        }

        public void Refresh()
        {
            dgvAirfield.Rows.Clear();
            foreach (var aircraft in _airfield.Aircrafts)
            {
                int id = dgvAirfield.Rows.Add(new object[] { aircraft.Id, aircraft.Name });
                dgvAirfield.Rows[id].Tag = aircraft;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            bool isNewAircraft = false;
            Aircraft aircraft = null;
            
            if (dgvAirfield.SelectedRows.Count > 0)
            {
                aircraft = (Aircraft)dgvAirfield.SelectedRows[0].Tag;
            }

            if (aircraft == null)
            {
                aircraft = new Aircraft();
                isNewAircraft = true;
            }

            var addEditForm = new AddEditForm(aircraft);
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                if (isNewAircraft) _airfield.Aircrafts.Add(aircraft);
                Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAirfield.SelectedRows.Count > 0)
            {
                var aircraft = (Aircraft)dgvAirfield.SelectedRows[0].Tag;

                if (
                    MessageBox.Show("Are you sure you want to delete this aircraft?",
                    "Delete confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _airfield.Aircrafts.Remove(aircraft);
                    Refresh();
                }
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Airfield));
                using (FileStream fs = File.Create(saveFileDialog.FileName))
                {
                    xmlSerializer.Serialize(fs, _airfield);
                }
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Airfield));
                using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                {
                    _airfield = (Airfield)xmlSerializer.Deserialize(fs);
                    Refresh();
                }
            }
        }
    }
}