using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorthims
{
    class BruteForce
    {
        static int basicOperations = 0;
        static Stopwatch stopwatch = new Stopwatch();

        static public int BruteForceMedian(int[] array)
        {
            // Returns the median value in a given array A of n numbers. This is
            // the kth element, where k = n 2, if the array was sorted.
            basicOperations = 0;
            stopwatch.Reset();

            int[] A = array;
            int k = (A.Length / 2) + 1;

            for (int x = 0; x < A.Length; x++)
            {
                int numsmaller = 0; // How many elements are smaller than A[i]
                int numequal = 0; // How many elements are equal to A[i]
               
                for (int y = 0; y < A.Length; y++)
                {
                    basicOperations++;
                    stopwatch.Start();
                    if (A[y] < A[x])
                    {
                        numsmaller += 1;
                    }
                    else if ((A[y] == A[x]))
                    {
                        numequal += 1;
                    }
                    stopwatch.Stop();
                }

                if (numsmaller < k && k <= (numsmaller + numequal))
                {
                    return A[x];
                }
            }
            return A[0];
        }

        //Return number of basic operations used.
        static public int GetBasicOperations()
        {
            return basicOperations;
        }

        //Return execution time of particular test.
        static public double GetTime()
        {
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
