using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Library
    {

        Book[] booksarray = new Book[4];
        public Library(Book[] arr)
        {
            booksarray = arr;
        }
        public void BorrowBook(string title)
        {
            int count = 0;
            for (int i = 0; i < booksarray.Length; i++)
            {
                if (booksarray[i].Title.Equals(title))
                {
                    booksarray[i].IsAvailable = false;
                    Console.WriteLine("Borrowed successfully");
                    count++;
                }
            }
            if (count == 0) { Console.WriteLine("Book not Available"); }
        }
        public void ReturnBook(string title)
        {
            for (int i = 0; i < booksarray.Length; i++)
            {
                if (booksarray[i].Title.Equals(title))
                {
                    booksarray[i].IsAvailable = true;
                    Console.WriteLine("Returned successfully");
                }
            }

        }
        public void DisplayBookDetails()
        {
            for (int i = 0; i < booksarray.Length; i++)
            {
                Console.WriteLine("Title :" + booksarray[i].Title + " Author :" + booksarray[i].Author + " Availablity " + booksarray[i].IsAvailable);
            }
        }
    }
}