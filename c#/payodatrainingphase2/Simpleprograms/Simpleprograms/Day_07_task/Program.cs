using Tasks;

Book book_1_details = new(101, "OnePiece", " Harsha", true);
Book book_2_details = new(102, "Naruto", "Mugesh", false);
Book book_3_details = new(103, "Cricket", "Virat", false);
Book book_4_details = new(104, "Harry potter", "Harry", true);

Library.bookslist.Add(book_1_details);
Library.bookslist.Add(book_2_details);
Library.bookslist.Add(book_3_details);
Library.bookslist.Add(book_4_details);

Library library = new Library();
int choice = 0;
while (choice != 4)
{
    Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter the title of the book to borrow");
        string? title = Console.ReadLine();
        Console.WriteLine(title);
        library.BorrowBook(title);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the title of the book to return");
        string title = Console.ReadLine();
        library.ReturnBook(title);
    }
    else if (choice == 3)
    {
        library.DisplayBookDetails();
    }
    else if (choice == 4)
    {
        break;
    }


}