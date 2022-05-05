using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecap_1066.Entities
{
    [Serializable]
    public class Book : IComparable<Book>
    {
        public string Title;
        public string Author;
        public bool IsRented;

        public Book() { }

        public Book(string title, string author, bool isRented) 
        { 
            Title = title;
            Author = author; 
            IsRented = isRented;
        }

        public int CompareTo(Book other)
        {
            return Author.CompareTo(other.Author);
        }
    }
}
