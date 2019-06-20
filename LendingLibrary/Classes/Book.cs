using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
        public enum Genre
        {
            Fantasy,
            SciFi, 
            History,
            NonFiction,
            Fiction,
            Romance,
            Horror,
            Mystry,
            Comedy
        }
    class Book
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public Author Author { get; set; }

        public Book(string title, Genre genre, Author author)
        {
            Title = title;
            Genre = genre;
            Author = author;

        }


    }
}
