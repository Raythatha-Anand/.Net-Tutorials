using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q18
    {
        public static void Main(string[] args)
        {
            int num = 1;
            for(int i= 1; i < 5; i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(num + " ");
                    num++ ;

                }
                Console.WriteLine();
            }
        }
    }
}
