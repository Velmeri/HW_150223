using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_150223
{
    internal class Library : IEnumerable, IEnumerator
    {
        private Book[] books;
        private int currentIndex = -1;

        public Library(Book[] books)
        {
            this.books = books;
        }

        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator) new LibraryEnumerator(this.books);
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private class LibraryEnumerator : IEnumerator
        {
            private Book[] books;
            private int currentIndex = -1;

            // Constructor with array of books
            public LibraryEnumerator(Book[] books)
            {
                this.books = books;
            }

            // Implementation of IEnumerator interface
            public bool MoveNext()
            {
                this.currentIndex++;
                return (this.currentIndex < this.books.Length);
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }

            public object Current
            {
                get
                {
                    if (this.currentIndex >= 0 && this.currentIndex < this.books.Length)
                        return this.books[this.currentIndex];
                    else
                        throw new InvalidOperationException();
                }
            }
        }
    }
}
