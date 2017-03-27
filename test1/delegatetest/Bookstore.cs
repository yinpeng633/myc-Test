using System;
using System.Collections;
namespace test1
{

    public class BookDB
    {
        // ArrayList list = new ArrayList();  mac里 .net 没有这个ArrayList 日了狗了
        private int booksSum;


        public void processPaperbackBooks(ProcessBookDelegate processBook)
        {
            for (int i = 0; i < 5; i++)
            {
                processBook(new Book());
            }
        }

        internal void addBook(string v1, string v2, decimal v3, bool v4)
        {
             booksSum++;
        }
    }

    public struct Book
    {
        public string title;
        public string author;
        public decimal price;
        public bool isPaperBook;

        public Book(string title, string author, decimal price, bool isPaperBook)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.isPaperBook = isPaperBook;
        }
    }

    public delegate void ProcessBookDelegate(Book book);

}
