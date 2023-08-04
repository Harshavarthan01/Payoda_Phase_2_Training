//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Simpleprograms
//{
//    internal class BankAccount
//    {
//        private readonly int account_number;
//        private double balance =0, deposit_amount, withdraw_amount;
//        private string? account_holder_name;

//      public  BankAccount(int account_number, string? account_holder_name)
//        {
//            this.Account_number = account_number;
//            this.Account_holder_name = account_holder_name;
//            this.Balance = balance;



//        }

        
//        public int Account_number { get => account_number; set => account_number = value; }
//        public string? Account_holder_name { get => account_holder_name; set => account_holder_name = value; }
//        public double Balance { get => balance; set => balance = value; }

//        public void Deposit(double deposit_amount) 
//        {
           
//            Balance = Balance + deposit_amount;
//            Console.WriteLine("Successfully deposited, available balance "+Balance+"rupees");
//        }

//        public void Withdraw(double Withdraw_amount)
//        {
//            if(Withdraw_amount <= Balance)
//            { 
//            Balance = Balance - Withdraw_amount;
//                Console.WriteLine("Successfully withdrawn, available balance " + Balance + "rupees");

//            }
//            else if(Withdraw_amount > Balance)
//            {
//                Console.WriteLine("Insufficient balance");
//            }
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Account holder name : " +Account_holder_name +"  Account number :"+Account_number + "  balance :"+Balance);

//        }



//    }
//}
