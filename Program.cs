using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price, discount, quantity, total, discountAmount, finalPrice;

            Console.Write("enter the price = ");

            price = double.Parse(Console.ReadLine());

            Console.Write("enter the quantity = ");

            quantity = int.Parse(Console.ReadLine());

            Console.Write("enter the discount = ");

            discount = int.Parse(Console.ReadLine());

            total = price * quantity;

            Console.WriteLine("total = " + total);

            discountAmount = (total * discount) / 100;

            Console.WriteLine("discontAmount = " + discountAmount);

            finalPrice = total - discountAmount;

            Console.WriteLine("finalPrice = " + finalPrice);
        }

    }
}
