using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Library : Book
    {
        public static ArrayList bookslist = new ArrayList();
       
        public void BorrowBook(string title)
        {
            Book.LendItem(title);
        }
        public void ReturnBook(string title)
        {
            foreach (Book i in bookslist)
            {
                if (i.Title.Equals(title))
                {
                    i.IsAvailable = true;
                    Console.WriteLine("Returned");
                }
            }

        }
        public void DisplayBookDetails()
        {
            foreach (Book i in bookslist)
            {
                Console.WriteLine("Title :" + i.Title + " Author :" + i.Author + " Availablity " + i.IsAvailable);
            }
        }
    }
}
