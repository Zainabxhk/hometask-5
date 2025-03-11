using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Home_Task
{
    internal class Book
    {
        private string Title;
        private string Author;
        private string Genre;
        private int PublicationYear;

        public Book()
        {
            Title = "OOP";
            Author = "zainab";
            Genre = "Programming";
            PublicationYear = 2020;
        }
        // Setters
        public void SetTitle(string title)
        {
            Title = title;
        }
        public void SetAuthor(string author)
        {
            Author = author;
        }
        public void SetGenre(string genre)
        {
            Genre = genre;
        }
        public void SetYear(int year)
        {
            PublicationYear = year;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public string GetGenre()
        {
            return Genre;
        }
        public int GetYear()
        {
            return PublicationYear;
        }
    }
}