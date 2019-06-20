using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        private T[] _books = new T[10];
        private int _bookCounter = 0;

        /// <summary>
        /// Displays the number of books present
        /// </summary>
        /// <returns>Number of books</returns>
        public int BookCount()
        {
            return _bookCounter;
        }

        /// <summary>
        /// Adds book object to the Library
        /// </summary>
        /// <param name="book">Book to be added to the Library</param>
        public void AddBook(T book)
        {
            if (_bookCounter == _books.Length)
            {
                Array.Resize(ref _books, _books.Length + 5);
            }

            _books[_bookCounter++] = book;
        }

        /// <summary>
        /// Removes book object and all items associated with the object if found
        /// </summary>
        /// <param name="book">The book to be removed</param>
        public void RemoveBook(T book)
        {
            T[] seekBook = _books;
            _books = new T[10];
            int seekCounter = _bookCounter;
            _bookCounter = 0;

            for (int i = 0; i < seekCounter; i++)
            {
                if (!seekBook[i].Equals(book))
                {
                    AddBook(seekBook[i]);
                }
            }

            if (_bookCounter == seekCounter)
            {
                throw new Exception("That book was not found please try again");
            }
        }


        /// <summary>
        /// Gets each item in the library.
        /// </summary>
        /// <returns>Library contents.</returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _bookCounter; i++)
            {
                yield return _books[i];
            }
        }
        /// <summary>
        /// Magic, don't touch.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
