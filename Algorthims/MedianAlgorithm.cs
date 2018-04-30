using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorthims
{
    class MedianAlgorithm
    {
        static public int Median(int[] array)
        {
            // Returns the median value in a given array A of n numbers.
            if (array.Length == 1)
            {
                return array[0];
            }
            else
            {
                return Select(array, 0, (array.Length/ 2), array.Length - 1); //Possible issue here
            }
        }

        static public int Select(int[] array, int lowerBound, int m, int upperBound)
        {
            // Returns the value at index m in array slice A[l..h], if the slice
            // were sorted into nondecreasing order.
            int pos = Partition(array, lowerBound, upperBound);
            if (pos == m)
            {
                return array[pos];
            }
            else if (pos > m)
            {
                return Select(array, lowerBound, m, pos - 1);
            }
            else
            {
                return Select(array, pos + 1, m, upperBound);
            }
        }

        static public int Partition(int[] _array, int lowerBound, int upperBound)
        {
            // Partitions array slice A[l..h] by moving element A[l] to the position
            // it would have if the array slice was sorted, and by moving all
            // values in the slice smaller than A[l] to earlier positions, and all values
            // larger than or equal to A[l] to later positions. Returns the index at which
            // the ‘pivot’ element formerly at location A[l] is placed.
            int[] array = _array;
            int pivotval = array[lowerBound];
            int pivotloc = lowerBound;
            
            for(int index = lowerBound + 1; index <= upperBound; index++)
            {
                if(array[index] < pivotval)
                {
                    //Swap
                    Swap(array, index, pivotloc);
                    pivotloc += 1;
                }
            }
            
            ////Swap **This is wrong. It doesnt place pivot back to original place **
            Swap(array, lowerBound, pivotloc);

            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x] + " ");
            }
            return pivotloc;
        }

        static int[] Swap(int[] array, int index, int pivotloc)
        {
            int[] tempArray = array;
            int tempValue = tempArray[index];
            tempArray[index] = tempArray[pivotloc];
            tempArray[pivotloc] = tempValue;

            return tempArray;
        }
    }
}
