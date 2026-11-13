using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 5000, amount;

            Console.WriteLine("Enter The Amount To Withdraw:");
            amount = int.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
            }
            else if (amount > balance)
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    else if (amount % 50 != 0)
                    {
                        Console.WriteLine("Please Enter Amount in Multiples of 50");
                    }
                    else
                    {
                        balance = balance - amount;

                        Console.Write("Change Remaining in Your account:  " + balance + "  Please Collect Your Cash");


                    }
        }
    }
}
