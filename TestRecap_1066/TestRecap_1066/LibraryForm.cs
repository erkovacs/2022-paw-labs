using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRecap_1066.Entities;

namespace TestRecap_1066
{
    public partial class LibraryForm : Form
    {
        private Library _library;
        public LibraryForm()
        {
            InitializeComponent();
            _library = new Library();
        }

        public void DisplayBooks()
        {
            // _library.Books.Sort((a, b) => a.Title.CompareTo(b.Title));
            _library.Books.Sort();
            dgvBooks.Rows.Clear();
            foreach (var book in _library.Books)
            { 
                int id = dgvBooks.Rows.Add(new object[] { book.Title, book.Author, book.IsRented });
                dgvBooks.Rows[id].Tag = book;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            bool isNewBook = true;
            Book book = new Book();

            if (dgvBooks.SelectedRows.Count > 0)
            {
                isNewBook = false;
                book = dgvBooks.SelectedRows[0].Tag as Book;
            }

            Form form = new BookForm(book);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (isNewBook)
                    _library.AddBook(book);

                DisplayBooks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                Book book = dgvBooks.SelectedRows[0].Tag as Book;
                if (MessageBox.Show(
                    $"Are you sure you want to delete {book.Title}?",
                    "Confirm deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    _library.Books.Remove(book);
                    DisplayBooks();
                }
            }
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = File.Create(dialog.FileName))
                {
                    formatter.Serialize(fs, _library);
                }
            }
        }

        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = File.OpenRead(dialog.FileName))
                {
                    _library = formatter.Deserialize(fs) as Library;
                    DisplayBooks();
                }
            }
        }
    }
}
