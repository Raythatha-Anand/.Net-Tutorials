using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q21
    {
        public static void Main(string[] args)
        {
            Console.Write("How many term you want : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int term = 0;

            Console.Write("==> ");

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + num;
                sum += term;

                Console.Write(term);

                if (i < n)
                    Console.Write(" + ");
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);

        }
    }
}
