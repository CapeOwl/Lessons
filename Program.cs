using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b, i;

            Console.WriteLine("Enter first number:");

            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("Enter second number:");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            Console.WriteLine("Sum or sub?");

            str = Console.ReadLine();

            if (str == "Sum")
            {
                i = a + b;

                Console.WriteLine("Summation " + i);
            }
            else
            {
                i = a - b;

                Console.WriteLine("Substraction " + i);



            }

            

        }
    }
}
