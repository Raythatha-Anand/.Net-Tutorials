using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q10
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter 10 digit number : ");
            string num = Console.ReadLine();
            string res = "";
            foreach (char digit in num)
            {
                if (res.Length >= 5)
                {
                    res += 'X';
                }
                else
                {
                    res += digit;
                }
            }
            Console.WriteLine("Converted number: " + res);
        }
    }
}
