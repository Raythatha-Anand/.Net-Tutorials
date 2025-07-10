using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q6
    {
        public static void Main(string[] args)
        {
            int a, b, c, result;

            Console.Write("Enter Number   1: ");

            //Missing statement

            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number  2 : ");

            //Missing statement

            b = Convert.ToInt32(Console.ReadLine());



            Console.Write("Enter Number   3 : ");

            c = Convert.ToInt32(Console.ReadLine());

            //Missing statement



            result = Sum(a, b, c);
            Console.WriteLine("Sum of 3 No is :- "+ result);

            //Missing statement





        }

        static int Sum(int x, int y, int z)

        {

            int res;

            res = x + y + z;

            return res;
        }
    }
}
