using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q5
    {
        public static void Main(string[] args)
        {
            //This line i initializes the n and fact values to 1.
            int n, fact = 1;

            //This line prompts the user to enter a number.
            Console.WriteLine("Enter Number : ");

            string str = Console.ReadLine();

            //This line converts the string input to an integer.
            n = Convert.ToInt32(str);


            // This loop calculates the factorial of the number n.
            for (int i = 1; i <= n; i++)

            {
                //This line multiplies the current value of fact by i.
                fact = fact * i;

            }

            Console.WriteLine("Factorial : {0}", fact);



            
        }
            
    }
}
