using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrip
{
    class Person
    {
        private Stack<Book> books;

        public Stack<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string BorrowBook(Book bookToBorrow)
        {
            books.Push(bookToBorrow);
            return "Borrowed " + bookToBorrow.BookName;
        }

        public string ReturnBook(List<Book> booklist)
        {
            booklist.Add(books.Pop());
            return "returned a book";
        }
    }
}
