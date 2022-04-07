using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        
        
        {

            try
            {
                Console.Write("Enter X : ");
                int x = Int32.Parse(Console.ReadLine());

                Console.Write("Enter Y : ");
                int y = Int32.Parse(Console.ReadLine());

                if (x > y)
                {
                    Console.WriteLine("X is big");


                }
                else if (x == y)
                {
                    Console.WriteLine("Both are Equal");
                }
                else
                {
                    Console.WriteLine("Y is Big");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Ei Tui bhul korsos");
               
            }
            Console.ReadLine();
        }
    }
}
