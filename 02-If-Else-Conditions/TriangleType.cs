using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c:");
            c = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Please enter positive integers.");
                return;
            }

            else if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("The numbers cannot form a triangle.");
            }

            else if (a == b && b == c)

                Console.WriteLine("Equilateral triangle.");

            else if (a == b && b != c || a == c && c != b || b == c && c != a)
            {
                Console.WriteLine("Isosceles triangle.");
            }
            else if (a != b && b != c && a != c)
            {
                Console.WriteLine("Scalene triangle.");
            }  













        }
    }
}
