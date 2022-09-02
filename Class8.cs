using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class8
    {
       
        public static void Main_()
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Input the 1st Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd Number : ");
            c = Convert.ToInt32(Console.ReadLine());



            if(a==b  && b==c)
            {
                Console.WriteLine("All are equal");
            }
            else if (a > b && a > c)
                Console.WriteLine("The 1st Number is greatest among the three.");
            else if (b > c)
                Console.WriteLine("The 2nd number is greatest among three.");
            else
                Console.WriteLine("The 3rd number is greatest among three.");

            Console.ReadKey();

        }

    }
}
