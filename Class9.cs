using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Class9
    {
       
        public static void Main_()
        {
            int x;
            int y;

            Console.WriteLine("enter the value of x coordinate : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y coordinate : ");
            y = Convert.ToInt32(Console.ReadLine());

            if(x==0)
            {
                if(y==0)
                {
                    Console.WriteLine("The coordinate ({0},{1}) lies at origin",x,y);
                }
                else if(y>0)
                {
                    Console.WriteLine("The coordinate ({0},{1}) lies on y-axix and on positive side", x, y);
                }
                else
                    Console.WriteLine("The coordinate ({0},{1}) lies on y-axix and on negative side", x, y);
            }
            else if(y==0)
            {
                 if (x > 0)
                {
                    Console.WriteLine("The coordinate ({0},{1}) lies on x-axix and on positive side", x, y);
                }
                else
                    Console.WriteLine("The coordinate ({0},{1}) lies on x-axix and on negative side", x, y);
            }
            else if(x>0 && y>0)
            {
                Console.WriteLine("The coordinate ({0},{1}) lies in the first Quadrant", x, y);

            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("The coordinate ({0},{1}) lies in the Second Quadrant", x, y);

            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate ({0},{1}) lies in the Third Quadrant", x, y);

            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate ({0},{1}) lies in the Fourth Quadrant", x, y);

            }





            Console.ReadKey();

        }
    }
}
