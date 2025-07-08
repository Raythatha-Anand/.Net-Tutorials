using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01
{
    internal class Q5
    {
        public static void Main(stirng[] args)
        {
            string[] abc = string[];
            Console.Write("Enter How many elements you want to Enter :- ");
            int lim = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<lim;i++){
                Console.Write("Enter Element No"+i+" :-")
                abc[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int a in abc){
                Console.Write(abc);
            }
        }
            
    }
}
