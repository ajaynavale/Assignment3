using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Armstrong
    {

        static void Main(string[] args)
        {
            int reminder = 0, sum = 0;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            for (temp = num; num != 0; num = num / 10)
            {
                reminder = num % 10;
                sum = sum + (reminder * reminder * reminder);
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is armstrong number");
            }
            else
            {
                Console.WriteLine("Number is not armstrong number");
            }
        }
    }
}
