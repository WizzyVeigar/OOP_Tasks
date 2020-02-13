using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrip
{
    class Book
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        private int bookLength;


        public int BookLenght
        {
            get { return bookLength; }
            set { bookLength = value; }
        }

        public Book(string bookName, string bookAuthor, int bookLenght)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            BookLenght = bookLenght;
        }
    }
}
