using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRecap_1066.Entities;

namespace TestRecap_1066
{
    public partial class BookForm : Form
    {
        private Book _book;

        public BookForm(Book book)
        {
            InitializeComponent();
            _book = book;
            ctrlTitle.Text = book.Title;
            ctrlAuthor.Text = book.Author;
            ctrlIsRented.Checked = book.IsRented;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _book.Title = ctrlTitle.Text;
            _book.Author = ctrlAuthor.Text;
            _book.IsRented = ctrlIsRented.Checked;
        }
    }
}
