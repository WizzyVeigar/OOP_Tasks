using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Book book1 = new Book("Book1", "Book1Auth", 160);
            Book book2 = new Book("Book2", "Book2Auth", 10);
            Book book3 = new Book("Book3", "Book3Auth", 110);
            Book book4 = new Book("Book4", "Book4Auth", 150);
            Book book5 = new Book("Book5", "Book5Auth", 50);
            //Library class
            List<Book> booksToBorrow = new List<Book>();
            Person person = new Person("Rick Astley", 54);

            while (true)
            {
                Console.WriteLine("What would you like to do? \n" +
                    "1. Borrow a book \n" +
                    "2. Return a book \n" +
                    "3. Check your current books");

                while (string.IsNullOrWhiteSpace(Console.ReadLine()))
                {

                }
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("What book would you like to borrow?");
                        foreach (Book book in booksToBorrow)
                        {
                            Console.WriteLine(book.BookName + " \n");
                        }
                        int choice = 0;
                        //This is really bad
                        switch (Console.ReadLine())
                        {
                            case "1":
                                choice = 1;
                                break;
                            case "2":
                                choice = 2;
                                break;
                            case "3":
                                choice = 3;
                                break;
                            default:
                                break;
                        }
                        person.BorrowBook(booksToBorrow[choice]);
                        break;
                    case "2":
                        person.ReturnBook(booksToBorrow);
                        break;
                    case "3":
                        foreach (Book book in person.Books)
                        {
                            Console.WriteLine(book.BookName);
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
