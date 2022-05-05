using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecap_1066.Entities
{
    [Serializable]
    public class Library
    {
        public int Id { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public Library(int id) : this()
        {
            Id = id;
        }

        public void AddBook(Book book)
        { 
            Books.Add(book); 
        }
    }
}
