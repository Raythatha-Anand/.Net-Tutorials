using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q19
    {
        public static void Main(string[] args)
        {
            int num = 4;

            for (int i = 1; i <= num; i++)
            {
                for (int space = 1; space <= num - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
