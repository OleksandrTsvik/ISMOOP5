using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDelegate;

public delegate double MathematicalFunctions(double x);
public delegate bool SortingBooks(Book firstBook, Book secondBook);
delegate void ShowEquation(string message);

namespace ConsoleAppDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            ShowEquation equation = delegate(string mes)
            {
                Console.WriteLine(mes);
            };

            //equation("4x^3 - 7x^2 + 1");
            //TabulationFunctions.Tabulate(-100000, 10000, 0.015, (x) => 4 * Math.Pow(x, 3) - 7 * Math.Pow(x, 2) + 1);

            //equation("√(6x^2 - 1)");
            //TabulationFunctions.Tabulate(-10000, 10000, 0.01, Func1);

            //equation("0.5x^(3+x) + 0.1x");
            //TabulationFunctions.Tabulate(-250, 400, 0.001, x => 0.5 * Math.Pow(x, 3 + x) + 0.1 * x);

            //equation("1 / √(0.5x^2 + 1)");
            //TabulationFunctions.Tabulate(-100000, 10000, 0.1, x => 1 / Math.Sqrt(0.5 * x * x + 1));

            //equation("|x^2-5| / (x-5)");
            //TabulationFunctions.Tabulate(-20000, 20000, 0.01, Func2);

            Console.WriteLine("\tВведені дані");
            ContainerBooks containerBooks;
            containerBooks = new ContainerBooks(new Book("Джури козака Швайки", "ВОЛОДИМИР РУТКІВСЬКИЙ", "А-ба-ба-га-ла-ма-га"));
            containerBooks = new ContainerBooks(new Book("Не-мов-ля", "ВІКТОРІЯ НІКОЛЕНКО", "Моя книжкова полиця"));
            containerBooks = new ContainerBooks(new Book("Снігова королева", "ГАНС КРІСТІАН АНДЕРСЕН", "А-ба-ба-га-ла-ма-га"));
            containerBooks = new ContainerBooks(new Book("Крута Архітектура", "САЙМОН АРМСТРОНҐ", "Моя книжкова полиця"));
            containerBooks = new ContainerBooks(new Book("Задивляюсь у твої зіниці", "ВАСИЛЬ СИМОНЕНКО", "А-ба-ба-га-ла-ма-га"));
            containerBooks = new ContainerBooks(new Book("Повернення в Портленд", "ГРИГОРІЙ ГУСЕЙНОВ", "Ярославів Вал"));
            containerBooks = new ContainerBooks(new Book("Українська народна іграшка", "ЛЮДМИЛА ГЕРУС", "Балтія-Друк"));
            containerBooks = new ContainerBooks(new Book("Тореадори з Васюківки", "ВСЕВОЛОД НЕСТАЙКО", "А-ба-ба-га-ла-ма-га"));
            containerBooks = new ContainerBooks(new Book("Ukraine - nature, traditions, culture. Англійською мовою", "ОЛЕКСАНДР БІЛОУСЬКО", "Балтія-Друк"));
            containerBooks = new ContainerBooks(new Book("Неймовірні пригоди Івана Сили", "ОЛЕКСАНДР ГАВРОШ", "А-ба-ба-га-ла-ма-га"));
            containerBooks = new ContainerBooks(new Book("Крута Фізика", "САРА ГАТТОН", "Моя книжкова полиця"));
            containerBooks = new ContainerBooks(new Book("Аніча. Все йде, все минає", "ЛЮДМИЛА ЯСНА", "Ярославів Вал"));
            containerBooks = new ContainerBooks(new Book("Життя та дивовижні пригоди козака Миколи на безлюдному острові", "ІГОР ФЕДІВ", "Ярославів Вал"));
            containerBooks = new ContainerBooks(new Book("Таємна перлина", "ЮРІЙ ЛОГВИН", "Ярославів Вал"));
            containerBooks = new ContainerBooks(new Book("The Motherlode", "Clover Hope", "Abrams Books"));
            Book book = new Book("Java in 24 Hours, Sams Teach Yourself (Covering Java 9), 8th Edition", "Rogers Cadenhead", "Sams Publishing");
            containerBooks = new ContainerBooks(book);
            book = new Book("Wrapped in Rain", "Charles Martin", "Thomas Nelson");
            containerBooks = new ContainerBooks(book);

            ContainerBooks.PrintContainer();

            // сортування за спаданням - book1.X.CompareTo(book2.X) == -1
            // сортування за зростанням - book1.X.CompareTo(book2.X) == 1
            // де X - це GetAuthor(), або GetBookTitle(), або GetPublishingHouse()

            ContainerBooks.Sort((book1, book2) => book1.GetAuthor().CompareTo(book2.GetAuthor()) == -1);
            Console.WriteLine("\tСортування по полю Author за спаданням");
            ContainerBooks.PrintContainer();

            ContainerBooks.Sort((book1, book2) => book1.GetBookTitle().CompareTo(book2.GetBookTitle()) == 1);
            Console.WriteLine("\tСортування по полю BookTitle за зростанням");
            ContainerBooks.PrintContainer();

            ContainerBooks.Sort((book1, book2) => book1.GetPublishingHouse().CompareTo(book2.GetPublishingHouse()) == -1);
            Console.WriteLine("\tСортування по полю PublishingHouse за спаданням");
            ContainerBooks.PrintContainer();

            ContainerBooks.Sort((book1, book2) => book1.GetAuthor().CompareTo(book2.GetAuthor()) == 1);
            Console.WriteLine("\tСортування по полю Author за зростанням");
            ContainerBooks.PrintContainer();
        }

        public static double Func1(double x)
        {
            if (6 * x * x >= 1)
                return Math.Sqrt(6 * x * x - 1);
            Console.WriteLine($"В точці x = {x, 0:f4} - функція y(x) невизначена!");
            return 0;
        }

        public static double Func2(double x)
        {
            if (x - 5 != 0)
                return Math.Abs(x * x - 5) / (x - 5);
            Console.WriteLine($"В точці x = {x, 0:f4} - функція y(x) невизначена!");
            return 0;
        }
    }
}
