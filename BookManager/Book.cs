using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;
        private static int totalBooks;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            totalBooks++;
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetTitleLength() => title.Length;

        public void SetTitle(string title)
        {
            if(title != null && title.Length > 0 )
            {
                this.title = title;
            }
            
        }
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }

        public string GetAuthor()
        {
            return author;
        }
        public static int GetTotalBooks() => totalBooks;

        static Book()
        {
            totalBooks = 0;
        }

    }
}
