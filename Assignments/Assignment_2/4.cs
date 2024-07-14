using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    class BookStore
    {
        public string ISBN;
        public string BookName;
        public string BookTitle;
        public string BookAuthor;
        public int BookCount;
        public int BookPrice;

        public BookStore(string iSBN, string bookName, string bookTitle, string bookAuthor, int bookCount, int bookPrice)
        {
            ISBN = iSBN;
            BookName = bookName;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookCount = bookCount;
            BookPrice = bookPrice;
        }

      

        public void Display()
        {
           Console .WriteLine(ISBN);
            Console.WriteLine(BookName);
            Console.WriteLine(BookTitle);
            Console.WriteLine(BookAuthor);
            Console.WriteLine(BookCount);
            Console.WriteLine(BookPrice);
            Console.WriteLine($"BillAmount:{BookPrice * BookCount}");


        }
    }

    internal class Book
    {
        static void Main(string[] args)
        {
            BookStore b = new BookStore("3131", "snl", "gayathri", "sri", 3, 10);
            b.Display();

        }
    }
}
