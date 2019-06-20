using LendingLibrary.Classes;
using System;
using Xunit;

namespace LibraryTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBook()
        {
            // Arrange
            Library<Book> testLibrary = new Library<Book>();
            Author testAuthor = new Author("Jon Rice");
            Book testBookToAdd = new Book ("The test of all books", Genre.Fantasy, testAuthor);

            // Act
            testLibrary.AddBook(testBookToAdd);

            // Assert
            Assert.NotEmpty(testLibrary);
        }

        [Fact]
        public void CanRemoveBook()
        {
            // Arrange
            Library<Book> testLibrary = new Library<Book>();
            Author testAuthor = new Author("Jon Rice");
            Book testBook = new Book("The test of all books", Genre.Fantasy, testAuthor);

            // Act
            testLibrary.AddBook(testBook);
            testLibrary.RemoveBook(testBook);

            // Assert
            Assert.Empty(testLibrary);

        }

        //[Fact]
        //public void CannotRemoveNonExistantBook()
        //{

        //}

        [Fact]
        public void CountOfBooks()
        {
            // Arrange
            Library<Book> testLibrary = new Library<Book>();
            Author testAuthor = new Author("Jon Rice");
            Book testBook = new Book("The test of all books", Genre.Fantasy, testAuthor);

            // Act
            testLibrary.AddBook(testBook);

            // Assert
            Assert.Equal(1, testLibrary.BookCount());


        }

        [Theory]
        [InlineData("Book 1", "Book 1")]
        [InlineData("Book 2", "Book 2")]
        [InlineData("Book 3", "Book 3")]
        [InlineData("Book 4", "Book 4")]
        [InlineData("Book 5", "Book 5")]
        public void BookPropertiesTitle(string expected, string title)
        {
            // Arrange
            Author testAuthor = new Author("Bob");
            Book testBook = new Book(title, Genre.History, testAuthor);

            // Assert
            Assert.Equal(expected, testBook.Title);
        }


        [Theory]
        [InlineData("Bob", "Bob")]
        [InlineData("Sally", "Sally")]
        [InlineData("Jon Rice", "Jon Rice")]
        [InlineData("Rice, Jon", "Rice, Jon")]
        [InlineData("", "")]
        public void AuthorProperties(string expected, string author)
        {
            Author testAuthor = new Author(author);

            Assert.Equal(expected, testAuthor.Name);
        }
    }
}
