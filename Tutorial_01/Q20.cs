using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q20
    {
        public static void Main(string[] args)
        {
            int n = 4;
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(sum+" ");
                    sum++;
                }

                Console.WriteLine();
            }
        }
    }
}
