using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {

            this.books = new List<Book>(books);
            this.books.Sort();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            //for (int i = 0; i < this.books.Count; i++)
            //{
            //    yield return this.books[i];
            //}
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        private class LibraryIterator:IEnumerator<Book>
        {
            private int index = -1;
            private List<Book> books;
            public LibraryIterator(IEnumerable<Book> books)
            {
                this.books = books.ToList();
            }
            public Book Current => this.books[index];
            object IEnumerator.Current => Current;
            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }
            public void Reset()
            {
                index = -1;
            }
            public void Dispose() { }
        }
    }
}
