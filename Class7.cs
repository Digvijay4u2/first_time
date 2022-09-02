using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class7
    {
        
        public static void Main_()
        {
            int m;

            Console.WriteLine("enter the value of m : ");
            m = Convert.ToInt32(Console.ReadLine());




            if (m > 0)
                Console.WriteLine("The value of n is 1");
            else if (m == 0)
                Console.WriteLine("The value of n is 0");
            else
                Console.WriteLine("The value of n is -1");

            Console.ReadKey();

        }
    }
}
