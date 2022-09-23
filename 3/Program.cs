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
            int i, j;
            double a = 0;
            for (i = 100; i <= 999; i++)
            {
                j = i;
                a = 0;
                while (j > 0)
                {
                    a = a + Math.Pow(j % 10, 3);
                    j = j / 10;
                }
                if (a == i)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
