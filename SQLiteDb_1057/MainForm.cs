using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using SQLiteDb_1057.Entities;

namespace SQLiteDb_1057
{
	internal partial class MainForm : Form
	{
		#region Attributes
		private readonly List<Participant> _participants;
		private const string _connectionString = "Data Source=database.db";

		#endregion

		public MainForm()
		{
			InitializeComponent();

			_participants = new List<Participant>();
		}

		#region Methods
		public void DisplayParticipants()
		{
			lvParticipants.Items.Clear();

			foreach (Participant participant in _participants)
			{
				var listViewItem = new ListViewItem(participant.Id.ToString());
				listViewItem.SubItems.Add(participant.LastName);
				listViewItem.SubItems.Add(participant.FirstName);
				listViewItem.SubItems.Add(participant.BirthDate.ToShortDateString());
				listViewItem.Tag = participant.Id;
				
				lvParticipants.Items.Add(listViewItem);
			}
		}
		#endregion

		private void CreateParticipant(Participant participant)
		{
			var query = "INSERT INTO Participant (FirstName, LastName, BirthDate) VALUES (@firstName, @lastName, @birthDate);";
			query += "SELECT last_insert_rowid();";

			using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
			{ 
				connection.Open();

				var command = new SQLiteCommand(query, connection);
				command.Parameters.AddWithValue("@firstName", participant.FirstName);
				command.Parameters.AddWithValue("@lastName", participant.LastName);
				command.Parameters.AddWithValue("@birthDate", participant.BirthDate.ToString());

				var id = (long) command.ExecuteScalar();
				participant.Id = id;

				_participants.Add(participant);
			}
		}

		private void ReadParticipants()
		{
			var query = "SELECT * FROM Participant;";

			using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
			{
				connection.Open();

				var command = new SQLiteCommand(query, connection);

				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var id = (long)reader["Id"];
						var lastName = (string)reader["LastName"];
						var firstName = (string)reader["FirstName"];
						var birthDate = DateTime.Parse((string)reader["BirthDate"]);

						var participant = new Participant(id, lastName, firstName, birthDate);
						_participants.Add(participant);
					}
				}
			}
		}

		private void UpdateParticipant(Participant participant)
        {
			var query = "UPDATE Participant SET LastName = @lastName, FirstName = @firstName, BirthDate = @birthDate WHERE Id = @id;";
			
			using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
			{
				connection.Open();

				var command = new SQLiteCommand(query, connection);
				command.Parameters.AddWithValue("@id", participant.Id);
				command.Parameters.AddWithValue("@firstName", participant.FirstName);
				command.Parameters.AddWithValue("@lastName", participant.LastName);
				command.Parameters.AddWithValue("@birthDate", participant.BirthDate.ToString());

				command.ExecuteScalar();
			}
		}
		
		private void DeleteParticipant(long id)
		{
			var query = "DELETE FROM Participant WHERE Id = @id;";
			
			using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
				connection.Open();
				var command = new SQLiteCommand(query, connection);
				command.Parameters.AddWithValue("@id", id);
				command.ExecuteNonQuery();
			}
		}

		#region Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			ReadParticipants();
			DisplayParticipants();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text;
			string lastName = tbLastName.Text;
			DateTime birthDate = dtpBirthDate.Value;

			var participant = new Participant(lastName, firstName, birthDate);

			try
			{
				CreateParticipant(participant);
			} 
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }

			DisplayParticipants();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lvParticipants.SelectedIndices.Count > 0)
            {
				if (MessageBox.Show("Confirm deletion",
					"Confirm deletion",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) == DialogResult.Yes)
				{
					var index = lvParticipants.SelectedIndices[0];
					var id = (long)lvParticipants.Items[index].Tag;

					try
					{
						DeleteParticipant(id);
						var participant = _participants.Find(p => p.Id == id);
						if (participant != null)
						{
							_participants.Remove(participant);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					DisplayParticipants();
				}
			}
		}
		#endregion

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (lvParticipants.SelectedIndices.Count > 0)
			{
				var index = lvParticipants.SelectedIndices[0];
				var id = (long)lvParticipants.Items[index].Tag;

				var participant = _participants.Find(p => p.Id == id);

				participant.LastName = tbLastName.Text;
				participant.FirstName = tbFirstName.Text;
				participant.BirthDate = dtpBirthDate.Value;

				UpdateParticipant(participant);
				DisplayParticipants();
			}
		}

        private void lvParticipants_DoubleClick(object sender, EventArgs e)
        {
			if (lvParticipants.SelectedIndices.Count > 0)
			{
				var index = lvParticipants.SelectedIndices[0];
				var id = (long)lvParticipants.Items[index].Tag;

				var participant = _participants.Find(p => p.Id == id);

				tbLastName.Text = participant.LastName;
				tbFirstName.Text = participant.FirstName;
				dtpBirthDate.Value = participant.BirthDate;
			}

		}
	}
}
