using System;
namespace Tutorial_01
{
    internal class Q11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' | gender == 'm')
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == 'F' | gender == 'f')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
            
        }

    }
}
