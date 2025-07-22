using System;

namespace Tutorial_01
{
    internal class Q20
    {
        static void Main()
        {
            int k = 1; 
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
