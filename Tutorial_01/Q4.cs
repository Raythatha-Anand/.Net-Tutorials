﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q4
    {
        public static void Main(string[] args)
        {
            int x;
            Console.Write("Enter Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even.");
            }
            else
            {
                Console.WriteLine("Number is Odd.");
            }
        }
    }
}
