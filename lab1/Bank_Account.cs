using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Bank_Account
    {
        
        string Email, User_Name, Account_type;
        double Account_no ,Account_Balance;


        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Number:-");
            Account_no = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Username:-");
            User_Name = Console.ReadLine();

            Console.WriteLine("Enter Email:-");
            Email = Console.ReadLine();

            Console.WriteLine("Enter Account Type (Current/Savings):-");
            Account_type = Console.ReadLine();

            Console.WriteLine("Enter Balancs:-");
            Account_Balance =Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number :- " + this.Account_no);

            Console.WriteLine("Email ID :- " + this.Email);

            Console.WriteLine("Username :- " + this.User_Name);

            Console.WriteLine("Account Type :- " + this.Account_type);

            Console.WriteLine("Balance is :- " + this.Account_Balance);
        }
    }

}

