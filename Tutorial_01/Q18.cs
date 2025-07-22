using System;

namespace Tutorial_01
{
    internal class Q18
    {
        static void Main(string[] args)
        {
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
