using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorthims
{
    class BruteForce
    {
        static public int BruteForceMedian(int[] array)
        {
            // Returns the median value in a given array A of n numbers. This is
            // the kth element, where k = n 2, if the array was sorted.

            int[] A = array;
            int k = (A.Length / 2) + 1;

            for (int x = 0; x < A.Length; x++)
            {
                int numsmaller = 0; // How many elements are smaller than A[i]
                int numequal = 0; // How many elements are equal to A[i]

                for (int y = 0; y < A.Length; y++)
                {
                    if (A[y] < A[x])
                    {
                        numsmaller += 1;
                    }
                    else if ((A[y] == A[x]))
                    {
                        numequal += 1;
                    }
                }

                if (numsmaller < k && k <= (numsmaller + numequal))
                {
                    return A[x];
                }
            }
            return A[0];
        }
    }
}
