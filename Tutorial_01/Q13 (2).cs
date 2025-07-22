using System;
namespace Tutorial_Q1
{
    internal class Q13
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.Write(a + " " + b);
            for (int i = 2; i < 11; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
        }
    }
}
