using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class MultiWithout
    {

        static void Main(string[] args)
        {
            int mul = 0;
            Console.WriteLine("Enter a two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num2; i++)
            {
                mul = mul + num1;
            }
            Console.WriteLine($"Multiplication is {mul} without using * operator");
        }
    }
}
