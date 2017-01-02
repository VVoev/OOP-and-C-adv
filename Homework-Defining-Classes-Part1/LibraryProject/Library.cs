using System.Collections.Generic;

namespace Homework_Defining_Classes_Part1
{
    public class Library
    {
        private string libraryName;
        private IList<Book> listOfBooks;

        public string LibraryName
        {
            get { return this.libraryName; }
            set { this.libraryName = value; }
        }

        public IList<Book> BookStore
        {
            get { return this.listOfBooks; }
            set { this.listOfBooks = value; }
        }


        public Library(string name, IList<Book> books)
        {
            this.LibraryName = name;
            this.BookStore = books;
        }

        //Methods in class Library
        public void AddBook(Book currentBook)
        {
            listOfBooks.Add(currentBook);
        }
        public void DeleteBook(Book currentBook)
        {
            listOfBooks.Add(currentBook);
        }
        public void PrintCurrentBook(Book currentBook)
        {
            currentBook.ToString();
        }
        public IList<Book> SearchBookByAuthor(string author)
        {
            var sortedBooksByAuthor = new List<Book>();
            foreach (Book book in listOfBooks)
            {
                if (book.Author == author)
                {
                    sortedBooksByAuthor.Add(book);
                }
            }
            return sortedBooksByAuthor;
        }

    }
}