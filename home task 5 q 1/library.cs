using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Home_Task
{
    class Library
    {
        private Book[] books; //Array of Books
        private int bookcount;

        public Library()
        {
            books = new Book[100];
            bookcount = 0;
        }

        public void AddBook(Book Book1)
        {
            books[bookcount] = Book1;
            bookcount++;
            Console.WriteLine("Book Added done");
        }
        public void ListAllBooks()
        {
            Console.WriteLine("All Books Available in Library");
            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine("Title " + books[i].GetTitle());
                Console.WriteLine("Auther " + books[i].GetAuthor());
                Console.WriteLine("Genre " + books[i].GetGenre());
                Console.WriteLine("Publication Year " + books[i].GetYear());
            }
        }
        public void SearchBooks(string keywod)
        {
            Console.WriteLine($"Serach Values for the Keyword = {keywod}");
            for (int i = 0; i < bookcount; i++)
            {
                if (books[i].GetTitle() == keywod || books[i].GetAuthor() == keywod || books[i].GetGenre() == keywod)
                {
                    Console.WriteLine("Title " + books[i].GetTitle());
                    Console.WriteLine("Auther " + books[i].GetAuthor());
                    Console.WriteLine("Genre " + books[i].GetGenre());
                    Console.WriteLine("Publication Year " + books[i].GetYear());
                }
            }
        }
    }
}