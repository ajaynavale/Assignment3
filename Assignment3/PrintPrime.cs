using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class PrintPrime
    {

        static void Main(string[] args)
        {
            int count = 0;
            int num;
            for (int i = 1; i <= 100; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num);
            }

        }

    }
}
