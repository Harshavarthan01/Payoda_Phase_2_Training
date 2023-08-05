//double num1, num2;
//int res;
//Console.WriteLine("Enter number 1");
//num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter number 2");

//num2 = Convert.ToDouble(Console.ReadLine());

//res = (int)(num1 + num2);
//Console.WriteLine("The result is " + res);



//------------------------------------------------------

//int num, sum = 0;

//num = Convert.ToInt32(Console.ReadLine());
//int temp = num;


//while (num > 0)
//{
//    int rem = num % 10;
//    sum += rem * rem * rem;
//    num = num / 10;
//}
//if (sum == temp)
//{
//    Console.WriteLine("Amstrong number");
//}
//else
//{
//    Console.WriteLine("not amstrong number");
//}

//-----------------------------------------------------------------

//int num, sum = 0;
//Console.WriteLine("Enter the Number");
//num = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= num / 2; i++)
//{
//    if (num % i == 0)
//    {
//        sum += i;
//    }
//}

//if (sum == num)
//{
//    Console.WriteLine("Perfect Number");
//}
//else
//{
//    Console.WriteLine(" Not an Perfect Number");
//}

//------------------------------------------------------------------

//int num1, num2, count = 0;
//Console.WriteLine("Enter the Number 1");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the Number 2");
//num2 = Convert.ToInt32(Console.ReadLine());

//for (int i = num1; i <= num2; i++)
//{
//     count = 0;
//    for (int j = 1; j <= i / 2; j++)
//    {
//        if (i % j == 0)
//        {
//            count++;
//        }
//    }
//    if (i == 1)
//    {
//        Console.WriteLine(i);
//    }
//    if (count == 1)
//    {
//        Console.WriteLine(i);
//    }
//}

//using Simpleprograms;

//Console.WriteLine("Consumer number :");
//int consumer_number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Consumer name :");
//string? consumer_name = Console.ReadLine();
//Console.WriteLine("Previous reading :");
//int previous_reading = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Current reading :");
//int current_reading = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Consumer type :");
//string? consumer_type = Console.ReadLine();


//ElectricReading electricReading = new ElectricReading("Harsha",1,"Commercial",100,350);
//int bill_amount = electricReading.CalculateBill(); 
//Console.WriteLine($"Bill : " +$"{electricReading.Consumer_name}  " + $"{electricReading.Consumer_number}  "+ bill_amount);

//----------------------------------------------------------------------------------------------


//Console.WriteLine("Enter Account Number");
//int account_number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Account Holder Number");
//string? account_holder_name = Console.ReadLine();
//double amount = 0;
//int option = 0;
//BankAccount bankAccount = new BankAccount(account_number, account_holder_name);
//while (option != 4)
//{
//    Console.WriteLine("Choose the option\n1.Deposit Amount\n2.Withdraw Amount\n3.Display Account Details\n4.Exit");
//    option = Convert.ToInt32(Console.ReadLine());
//    if (option == 1)
//    {
//        Console.WriteLine("Enter the amount to be deposit");
//        amount = Convert.ToDouble(Console.ReadLine());
//        bankAccount.Deposit(amount);
//    }
//    else if (option == 2)
//    {
//        Console.WriteLine("Enter the amount to be withdraw");
//        amount = Convert.ToDouble(Console.ReadLine());
//        bankAccount.Withdraw(amount);
//    }
//    else if (option == 3)
//    {
//        bankAccount.Display();
//    }
//    else if (option == 4)
//    {
//        break;
//    }


//}

//--------------------------------------------------------------------------------

using Simpleprograms;

//Book[] arr = { new Book(1, "Life of Harsha", "Harsha", true), new Book(2, "Nice", "Jaya", true), new Book(3, "parker", "Yogesh", true), new Book(4, "Reality kills", "Sanjay", false) };
//Library library = new Library(arr);
//int option = 0;
//while (option != 4)
//{
//    Console.WriteLine("Choose the option\n1.Display Books\n2.Borrow Book\n3.Return Book\n4.Exit"); 
//    option = Convert.ToInt32(Console.ReadLine());
//    if (option == 2)
//    {
//        Console.WriteLine("Enter the title of the book to borrow");
//        string? title = Console.ReadLine();
//        library.BorrowBook(title);
//    }
//    else if (option == 3)
//    {
//        Console.WriteLine("Enter the title of the book to return");
//        string? title = Console.ReadLine();
//        library.ReturnBook(title);
//    }
//    else if (option == 1)
//    {
//        library.DisplayBookDetails();
//    }
//    else if (option == 4)
//    {
//        break;
//    }
//}
//-----------------------------------------------------------------------------

//Staticdemo.Calc();
//Console.WriteLine("Amount to be paid: $" + Staticdemo.Amt);
//-----------------------------------------------------------------------------

StudentGrade studentMarks = new StudentGrade("Payoda College", "Tidelpark",100,"Arun","Coimbatore",75,85,95);

Console.WriteLine("Student Details :");

Console.WriteLine(studentMarks.Rno);
Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.Collegename);
Console.WriteLine(studentMarks.Collegeaddress);
Console.WriteLine("Total :"+studentMarks.Calculatetotal());
Console.WriteLine("Average :" + studentMarks.Calculateaverage());
Console.WriteLine("Grade :" + studentMarks.CalculateGrade());


//---------------------------------------------------------------------------------

TeachingStaff teachingStaff = new("Payoda College","Tidelpark",101, "Harsha", "SDFG", "CSE", 10000, 40, 25, 10, 5);

NonTeachingStaff nonTeachingStaff = new("AppviewX College", "Tidelpark",102, "Harish", "SPD", 8000, 30, 15, 5, 3);




Console.WriteLine("Teaching Staff Salary :");
Console.WriteLine(teachingStaff.Name);
Console.WriteLine(teachingStaff.Dept);
Console.WriteLine(teachingStaff.Basic_salary);
Console.WriteLine(teachingStaff.Collegename);
Console.WriteLine(teachingStaff.Collegeaddress);
Console.WriteLine(teachingStaff.CalculateSalary());

Console.WriteLine("NonTeaching Staff Salary :");
Console.WriteLine(nonTeachingStaff.Name);
Console.WriteLine(nonTeachingStaff.Basic_salary);
Console.WriteLine(nonTeachingStaff.Collegename);
Console.WriteLine(nonTeachingStaff.Collegeaddress);
Console.WriteLine(nonTeachingStaff.CalculateSalary());



