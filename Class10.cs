using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class10
    {

        public static void Main_()
        {
            int math;
            int phy;
            int che;


            Console.WriteLine("Input the marks obtained in Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics : ");
            math = Convert.ToInt32(Console.ReadLine());

            int total = (math + phy + che);

            if (math >= 65 && phy >= 55 && che >= 50 && total >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
                Console.WriteLine("The candidate is not eligible for admission.");

            Console.ReadKey();
        }
    }
}
