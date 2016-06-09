using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerProb1
{
    /*
     *  If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 
        Find the sum of all the multiples of 3 or 5 below 1000.
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            long sumMultiples = 0;

            for (long i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumMultiples += i;
                }
            }

            Console.WriteLine("Sum of multiples: " + sumMultiples.ToString());
            Console.ReadLine();
        }
    }
}
