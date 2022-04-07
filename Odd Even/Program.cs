using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int p = Int32.Parse(Console.ReadLine());

            if (p % 2 == 0)
            {
                Console.WriteLine("The Numbre is Even");
            }
            else
            {
                Console.WriteLine("The Number in Odd");
            }
            Console.ReadLine();
        }
    }
}
