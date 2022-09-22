using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 50; i <= 80; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                    Console.WriteLine(i);
                }
                //count = count + 1;
                // Console.WriteLine($"Count is {count}");
            }
            Console.WriteLine($"Count is {count}");

        }
    }
}
