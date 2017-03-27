using System;
namespace test1
{
    using test1;
    public class DelegateTest
    {
        public DelegateTest()
        {
        }

        static void PrintTitle(Book b)
        {
            Console.WriteLine("   {0}", b.title);
        }

        // static void Main(string[] args)
        // {
        //     BookDB bookDB = new BookDB();
        //     AddBooks(bookDB);
        //     //委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递，这种将方法动态地赋给参数的做法，可以避免在程序中大量使用If-Else(Switch)语句，同时使得程序具有更好的可扩展性。
        //     Console.WriteLine("Paperback Book Titles:");
        //     bookDB.processPaperbackBooks(new ProcessBookDelegate(PrintTitle));  //????

        //     PriceToataller totaller = new PriceToataller();
        //     bookDB.processPaperbackBooks(new ProcessBookDelegate(totaller.addBookToTotal));
        // }

        static void AddBooks(BookDB bookDB)
        {
            bookDB.addBook("The C Programming Language",
               "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.addBook("The Unicode Standard 2.0",
               "The Unicode Consortium", 39.95m, true);
            bookDB.addBook("The MS-DOS Encyclopedia",
               "Ray Duncan", 129.95m, false);
            bookDB.addBook("Dogbert's Clues for the Clueless",
               "Scott Adams", 12.00m, true);
        }
    }


    public class PriceToataller
    {
        int bookCount = 0;
        decimal priceBooks = 0.0m;

        internal void addBookToTotal(Book book)
        {
            bookCount++;
            priceBooks += book.price;
        }

        internal decimal averagePrice()
        {
            return priceBooks / bookCount;
        }

    }
}
