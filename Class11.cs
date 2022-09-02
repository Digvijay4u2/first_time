using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class11
    {
        
        public static void Main_()
        {
            int a;

            Console.WriteLine("Input Number of terms : ");
            a = Convert.ToInt32(Console.ReadLine());

            

            for(int i=1;i<=a;i++)
            {
                Console.WriteLine("Number is : {0} and cube of the {0} is : {1}",i, Math.Pow(i, 3));
            }


           

            Console.ReadKey();

        }
    }
}
