using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First value : ");
            int x = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Enter Second value : ");
            int y = Int32.Parse(Console.ReadLine());

            String s1 = String.Format("The sum of {0} + {1} is {2}", x, y, (x + y));
            Console.WriteLine(s1);

            Console.WriteLine("The sum of {0} +{1} is {2} ", x, y, (x + y));
            Console.WriteLine("The sub of {0} + {1} is {2} ", x, y, (x - y));
            Console.WriteLine("The mul of {0} +{1} is {2} ", x, y, (x * y));
            Console.WriteLine("The div of {0} +{1} is {2} ", x, y, (x / y));

            Console.ReadLine();
        }
    }
}
