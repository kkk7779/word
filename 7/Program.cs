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
            int zm = 0, kg = 0, sz = 0, qt = 0;
            string str = string.Empty;
            str = Console.ReadLine();
            foreach (char i in str)
            {
                if (i >= 'a' && i <= 'z' || i >= 'A' && i <= 'Z')
                    zm++;
                else if (i == ' ')
                    kg++;
                else if (i >= '0' && i <= '9')
                    sz++;
                else
                    qt++;

            }
            Console.WriteLine("英文字母：" + zm);
            Console.WriteLine("空格：" + kg);
            Console.WriteLine("数字：" + sz);
            Console.WriteLine("其他字符：" + qt);
        }
    }
}
