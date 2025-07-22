using System;
namespace Tutorial_01
{
    internal class Q19
    {
        static void Main(string[] args)
        {
            int n = 4; 

            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
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
