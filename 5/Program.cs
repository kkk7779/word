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
            switch (n / 10)
            {
                case 10: Console.WriteLine("A"); break;
                case 9: Console.WriteLine("A"); break;
                case 6: Console.WriteLine("B"); break;
                case 7: Console.WriteLine("B"); break;
                case 8: Console.WriteLine("B"); break;
                default: Console.WriteLine("C"); break;
            }
            Console.WriteLine();
        }
    }
}
