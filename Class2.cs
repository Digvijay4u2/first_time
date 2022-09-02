using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class2
    {
        static bool isEven(int a)
        {
            return a%2==0;
        }
        public static void Main_()
        {
            int a;
           
            Console.WriteLine("Input Number : ");
            a = Convert.ToInt32(Console.ReadLine());

            
            

            if (isEven(a))
                Console.WriteLine("{0} is an Even Integer", a);
            else
                Console.WriteLine("{0} is an odd Integer", a);

            Console.ReadKey();

        }
    }
}
