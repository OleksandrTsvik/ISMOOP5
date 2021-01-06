using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDelegate;

public delegate double MathematicalFunctions(double x);
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

            ContainerBooks containerBooks = new ContainerBooks();
            containerBooks.AddBook(new Book("Джури козака Швайки", "ВОЛОДИМИР РУТКІВСЬКИЙ", "А-ба-ба-га-ла-ма-га"));
            containerBooks.AddBook(new Book("Не-мов-ля", "ВІКТОРІЯ НІКОЛЕНКО", "Моя книжкова полиця"));
            containerBooks.AddBook(new Book("Снігова королева", "ГАНС КРІСТІАН АНДЕРСЕН", "А-ба-ба-га-ла-ма-га"));
            containerBooks.AddBook(new Book("Крута Архітектура", "САЙМОН АРМСТРОНҐ", "Моя книжкова полиця"));
            containerBooks.AddBook(new Book("Задивляюсь у твої зіниці", "ВАСИЛЬ СИМОНЕНКО", "А-ба-ба-га-ла-ма-га"));
            containerBooks.AddBook(new Book("Повернення в Портленд", "ГРИГОРІЙ ГУСЕЙНОВ", "Ярославів Вал"));
            containerBooks.AddBook(new Book("Українська народна іграшка", "ЛЮДМИЛА ГЕРУС", "Балтія-Друк"));
            containerBooks.AddBook(new Book("Тореадори з Васюківки", "ВСЕВОЛОД НЕСТАЙКО", "А-ба-ба-га-ла-ма-га"));
            containerBooks.AddBook(new Book("Ukraine - nature, traditions, culture. Англійською мовою", "ОЛЕКСАНДР БІЛОУСЬКО", "Балтія-Друк"));
            containerBooks.AddBook(new Book("Неймовірні пригоди Івана Сили", "ОЛЕКСАНДР ГАВРОШ", "А-ба-ба-га-ла-ма-га"));
            containerBooks.AddBook(new Book("Крута Фізика", "САРА ГАТТОН", "Моя книжкова полиця"));
            containerBooks.AddBook(new Book("Аніча. Все йде, все минає", "ЛЮДМИЛА ЯСНА", "Ярославів Вал"));
            containerBooks.AddBook(new Book("Життя та дивовижні пригоди козака Миколи на безлюдному острові", "ІГОР ФЕДІВ", "Ярославів Вал"));
            containerBooks.AddBook(new Book("Таємна перлина", "ЮРІЙ ЛОГВИН", "Ярославів Вал"));
            containerBooks.AddBook(new Book("The Motherlode", "Clover Hope", "Abrams Books"));
            Book book = new Book("Java in 24 Hours, Sams Teach Yourself (Covering Java 9), 8th Edition", "Rogers Cadenhead", "Sams Publishing");
            containerBooks.AddBook(book);
            book = new Book("Wrapped in Rain", "Charles Martin", "Thomas Nelson");
            containerBooks.AddBook(book);

            Console.WriteLine("\tВведені дані");
            containerBooks.PrintContainer();

            containerBooks.Sort(ContainerBooks.CompareByAuthor, ContainerBooks.Order.Descending);
            Console.WriteLine("\tСортування по полю Author за спаданням");
            containerBooks.PrintContainer();

            containerBooks.Sort(ContainerBooks.CompareByBookTitle, ContainerBooks.Order.Ascending);
            Console.WriteLine("\tСортування по полю BookTitle за зростанням");
            containerBooks.PrintContainer();

            containerBooks.Sort(ContainerBooks.CompareByPublishingHouse, ContainerBooks.Order.Descending);
            Console.WriteLine("\tСортування по полю PublishingHouse за спаданням");
            containerBooks.PrintContainer();

            containerBooks.Sort(ContainerBooks.CompareByAuthor);
            Console.WriteLine("\tСортування по полю Author за зростанням");
            containerBooks.PrintContainer();
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
