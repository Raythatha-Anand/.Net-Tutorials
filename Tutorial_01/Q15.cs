﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q15
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, temp = num;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }

            if (sum == num) 
            {
                Console.WriteLine("Armstrong Number");
            }
                
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
                
        }
    }
}
