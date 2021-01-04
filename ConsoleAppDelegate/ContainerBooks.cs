using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    public class ContainerBooks
    {
        public static List<Book> Books = new List<Book>();

        public ContainerBooks(Book book)
        {
            Books.Add(book);
        }

        public static void Sort(SortingBooks method)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                for (int j = 0; j < Books.Count; j++)
                {
                    if (method(Books[i], Books[j]))
                    {
                        Book temp = Books[i];
                        Books[i] = Books[j];
                        Books[j] = temp;
                    }
                }
            }
        }

        public static void PrintContainer()
        {
            foreach (Book book in Books)
                Console.WriteLine($"{book.GetBookTitle()} - {book.GetAuthor()} - {book.GetPublishingHouse()}");
            Console.WriteLine("\n\n");
        }
    }
}
