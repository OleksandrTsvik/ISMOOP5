using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    public class Book
    {
        protected string BookTitle;
        protected string Author;
        protected string PublishingHouse;

        public Book(string bookTitle, string author, string publishingHouse)
        {
            SetBookTitle(bookTitle);
            SetAuthor(author);
            SetPublishingHouse(publishingHouse);
        }
        public Book(string bookTitle, string author)
        {
            SetBookTitle(bookTitle);
            SetAuthor(author);
            SetPublishingHouse("Unknown");
        }

        public Book()
        {
            SetBookTitle("Unknown");
            SetAuthor("Unknown");
            SetPublishingHouse("Unknown");
        }

        public void SetBookTitle(string bookTitle)
        {
            if (bookTitle.Length >= 3)
                BookTitle = bookTitle;
            else
                BookTitle = "Unknown";
        }

        public void SetAuthor(string author)
        {
            if (author.Length >= 3)
                Author = author;
            else
                Author = "Unknown";
        }

        public void SetPublishingHouse(string publishingHouse)
        {
            if (publishingHouse.Length >= 3)
                PublishingHouse = publishingHouse;
            else
                PublishingHouse = "Unknown";
        }

        public string GetBookTitle()
        {
            return BookTitle;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public string GetPublishingHouse()
        {
            return PublishingHouse;
        }
    }
}
