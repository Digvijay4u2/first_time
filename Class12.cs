using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class12
    {
        

        public static void Main_()
        {
            int a;

            Console.Write("Input the  Number (Table to be calculated) : ");
            a = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }



            

            Console.ReadKey();

        }
    }
}
