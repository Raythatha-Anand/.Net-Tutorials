using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q22
    {
        public static void Main(string[] args)
        {
            int n = 9;

            for (int i = 1; i <= n; i++)
            {

                int k = n / 2;
                int terms = (i <= k) ? (2 * i) - 1 : n - ((2 * i - 1) - n);
                int spaces = (i <= k) ? k - i + 1 : i - k - 1;

                for (int space = 1; space <= spaces; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= terms; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
