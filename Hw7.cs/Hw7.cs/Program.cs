using System;
using System.Collections.Generic;
using System.Text;

namespace Hw7.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();

            library.AddBooks("Lord of the Rings ", "J.R.R. Tolkien", 400);
            library.AddBooks("Harry Poter", " J.K. Rowling", 400);
            library.AddBooks("Alice's Adventures in Wonderland", " Lewis Carroll", 400);
            library.AddBooks("Pinocchio", "Carlo Collodi ", 400);
            string aa = "400";

            foreach (var item in library.SearchBooks(aa))
            {
                Console.WriteLine(item);
            }



        }
    }
}
