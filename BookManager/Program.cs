using System;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int nBooks;
            Book[] bookerinos;
            //asking for the number of books
            Console.WriteLine("insert the number of books");
            nBooks = Convert.ToInt32(Console.ReadLine());
            bookerinos = new Book[nBooks];

            //for each book
            for(int i = 0; i < nBooks; i++)
            {
                //declare variables
                string title, author;
                Book b;
                //ask for title
                Console.Write("Title: ");
                title = Console.ReadLine();
                //ask for author
                Console.Write("Auhor: ");
                author = Console.ReadLine();
                //create a book object
                b = new Book(title, author);
                //save title in array
                bookerinos[i] = b;
            }
            //for each book specified
            foreach(Book b in bookerinos)
            {
                //show title 
                Console.WriteLine($"Titulo:{b.GetTitle()}");
                //show lenght
                Console.WriteLine("Comprimento: {0}", b.GetTitleLength());
                //show author
                Console.WriteLine("Author: " + b.GetAuthor());
            }
        }
    }
}
