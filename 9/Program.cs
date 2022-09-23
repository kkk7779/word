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
            double a = 100, sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + a + 0.5 * a;
                a = 0.5 * a;
            }
            Console.WriteLine(sum);
        }


    }
}