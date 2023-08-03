//double num1, num2;
//int res;
//Console.WriteLine("Enter number 1");
//num1 =Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter number 2");

//num2 = Convert.ToDouble(Console.ReadLine());

//res = (int)(num1 + num2);
//Console.WriteLine("The result is "+res);



//------------------------------------------------------

//int num, sum = 0;

//num=Convert.ToInt32(Console.ReadLine());
//int temp = num;


//while (num > 0)
//{
//    int rem = num % 10;
//    sum += rem * rem * rem;
//    num = num / 10;
//}
//if(sum == temp)
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

int num1, num2, count = 0;
Console.WriteLine("Enter the Number 1");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Number 2");
num2 = Convert.ToInt32(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
     count = 0;
    for (int j = 1; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            count++;
        }
    }
    if (i == 1)
    {
        Console.WriteLine(i);
    }
    if (count == 1)
    {
        Console.WriteLine(i);
    }
}