using LendingLibrary.Classes;
using System;
using System.Collections.Generic;

namespace LendingLibrary
{
    class Program
    {
        static void BorrowBook(Library<Book> library)
        {
            List<Book> listOfBooksOne = new List<Book>();
            List<Book> listOfBooksTwo = new List<Book>();

            int bookCounter = 0;

            Console.WriteLine("Available Books in the Library");
            foreach (Book book in library)
            {
                Console.WriteLine($"{book.Title} by {book.Author.Name}");
                if (bookCounter %2 == 0)
                {
                    listOfBooksOne.Add(book);
                }
                else
                {
                    listOfBooksTwo.Add(book);
                    bookCounter++;
                }
            }
        }

        static void Main(string[] args)
        {
            Author author1 = new Author("Jon Rice");

            Book book1 = new Book("The best book in the world", Genre.Romance, author1);
            Book book2 = new Book("The best book in the world", Genre.Comedy, author1);
            Book book3 = new Book("The best book in the world", Genre.Fantasy, author1);
            Book book4 = new Book("The best book in the world", Genre.NonFiction, author1);
            Book book5 = new Book("The best book in the world", Genre.History, author1);


            Library<Book> lendingLibrary = new Library<Book>();
            lendingLibrary.AddBook(book1);
            lendingLibrary.AddBook(book2);
            lendingLibrary.AddBook(book3);
            lendingLibrary.AddBook(book4);
            lendingLibrary.AddBook(book5);


            BorrowBook(lendingLibrary);

        }
    }
}
