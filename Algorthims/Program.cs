using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorthims
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 4, 1, 10, 9, 7, 12, 8, 2, 15 };
            //Console.WriteLine(BruteForce.BruteForceMedian(A));
            MedianAlgorithm.Partition(A,0,7); //Testing the two swaps for values 1 and 2.
            Console.ReadLine();
        }
        
    }
}
