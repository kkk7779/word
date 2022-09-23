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
            int m = int.Parse(Console.ReadLine());
            int i, j, temp;
            if (m > n)
            {
                temp = m;
                m = n;
                n = temp;

            }
            for (i = n; i <= m * n; i++)
            {
                if (i % n == 0 && i % m == 0)
                    break;
            }
            Console.WriteLine("最小公倍数为：" + i);
            for (i = m; i >= 1; i--)
            {
                if (m % i == 0 && n % i == 0)
                    break;
            }
            Console.WriteLine("最大公约数为：" + i);
        }
    }
}
