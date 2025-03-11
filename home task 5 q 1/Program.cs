using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Home_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetTitle("OOP");
            book1.SetAuthor("Ali");
            book1.SetGenre("coding");
            book1.SetYear(2021);

            Book book2 = new Book();
            book2.SetTitle("DBS");
            book2.SetAuthor("Umar");
            book2.SetGenre("Data");
            book2.SetYear(2020);

            Book book3 = new Book();

            Library library_Object = new Library();
            library_Object.AddBook(book1);
            library_Object.AddBook(book2);
            library_Object.AddBook(book3);

            library_Object.ListAllBooks();

            string Query = "Ali";
            library_Object.SearchBooks(Query);

        }
    }
}