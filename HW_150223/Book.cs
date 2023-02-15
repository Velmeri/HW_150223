using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_150223
{
    internal class Book : IComparable, IComparer, ICloneable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public Book() { }

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Book book = obj as Book;
            if (book != null)
                return this.Title.CompareTo(book);
            else
                throw new ArgumentException("Obj isn't a Book!!!");
        }

        public int Compare(object x, object y)
        {
            Book book1 = x as Book;
            Book book2 = y as Book;

            if (book1 == null || book2 == null)
                throw new ArgumentException("Obk isn't a Book");

            return this.Title.CompareTo(book1.Title);
        }

        public object Clone()
        {
            return new Book(this.Title, this.Author, this.PublicationYear);
        }
    }
}
