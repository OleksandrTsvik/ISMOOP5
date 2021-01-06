using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    public class ContainerBooks
    {
        public delegate int BookComparator(Book firstBook, Book secondBook);
        protected List<Book> Books;
        public enum Order { Ascending, Descending };
        public ContainerBooks()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public Book this[int index]
        {
            get
            {
                return Books[index];
            }
        }

        public static int CompareByBookTitle(Book firstBook, Book secondBook)
        {
            return firstBook.GetBookTitle().CompareTo(secondBook.GetBookTitle());
        }

        public static int CompareByAuthor(Book firstBook, Book secondBook)
        {
            return firstBook.GetAuthor().CompareTo(secondBook.GetAuthor());
        }

        public static int CompareByPublishingHouse(Book firstBook, Book secondBook)
        {
            return firstBook.GetPublishingHouse().CompareTo(secondBook.GetPublishingHouse());
        }

        public void Sort(BookComparator method, Order order = Order.Ascending)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                for (int j = 0; j < Books.Count; j++)
                {
                    if ((method(Books[i], Books[j]) > 0 && order == Order.Ascending) || (method(Books[i], Books[j]) < 0 && order == Order.Descending))
                    {
                        Book temp = Books[i];
                        Books[i] = Books[j];
                        Books[j] = temp;
                    }
                }
            }
        }

        public void PrintContainer()
        {
            foreach (Book book in Books)
                Console.WriteLine($"{book.GetBookTitle()} - {book.GetAuthor()} - {book.GetPublishingHouse()}");
            Console.WriteLine("\n\n");
        }
    }
}
