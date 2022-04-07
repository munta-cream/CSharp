using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop_example_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i<=100)
            {
                if (i%2!=0)
                {
                    Console.Write("{0}\t", i);
                } 

                
                //i=i+1;
                i++;
                
            }

           

            Console.ReadLine();
        }
    }
}
