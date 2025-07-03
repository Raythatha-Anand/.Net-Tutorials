using System;


namespace Tutorial_01
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number :- ");
            n = Convert.ToInt32(Console.ReadLine());
            if ((n % 2) == 0)
            {
                Console.WriteLine("Given Number is Even.");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }

        }
    }
}
