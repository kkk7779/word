﻿using System;
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
            int a;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if (i != j && j != k && i != k)
                        {
                            a = i * 100 + j * 10 + k;
                            Console.WriteLine(a);
                        }
                    }
                }
            }
        }


    }
}
