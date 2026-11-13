using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int num1, num2, num3;

            Console.WriteLine("enter num1");
            
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter num2");
            
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter num3");
            
            num3 = int.Parse(Console.ReadLine());



            if (num1 == num2 && num1 == num3)
            {
                Console.Write("All numbers are equal");
            }

            else if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is the largest");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("num2 is the largest");
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.Write("num3 is the largest");

            }


        }

    }
}
