using System;


namespace Tutorial_01
{
    internal class Q13
    {
        public static void Main(string[] args)
        {
            Console.Write("enter the limit:- ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a + " " + b + " ");
            for (int i = 0; i < limit; i++)
            {

                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;


            }

        }

    }
}
