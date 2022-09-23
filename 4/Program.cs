using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("n=");
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i);
                    n = n / i;
                    if (n != 1)
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
