using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            string res = "";
            foreach (char i in s)
            {
                if (char.IsUpper(i))
                {
                    res += char.ToLower(i);
                }
                else if (char.IsLower(i))
                {
                    res += char.ToUpper(i);
                }
                else
                {
                    res += i; 
                }
            }
            Console.WriteLine("Converted string: " + res);
        }
    }
}
