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
            int i, j, sum = 0;
            for (i = 1; i <= 1000; i++)
            {
                sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine(i);
            }
        }
    }
}
