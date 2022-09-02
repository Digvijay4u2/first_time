using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class1
    {

        static bool isEqual(int a,int b)
        {
            return a == b;
        }
        public static void Main_()
        {
            int a;
            int b;
            Console.WriteLine("Input 1st Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            if (isEqual(a, b))
                Console.WriteLine("{0} and {1} are equal",a,b);
            else
                Console.WriteLine("{0} and {1} are unequal",a,b);

            Console.ReadKey();

        }
    }
}
