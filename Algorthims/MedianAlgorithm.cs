using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorthims
{
    class MedianAlgorithm
    {
        static int basicOperations = 0;
        static Stopwatch stopwatch = new Stopwatch();

        // Returns the median value in a given array A of n numbers.
        static public int Median(int[] array)
        {
            basicOperations = 0;
            stopwatch.Reset();

            if (array.Length == 1) //If there is only one item in the array, it is the median.
            {
                return array[0];
            }
            else
            {
                return Select(array, 0, (array.Length/ 2), array.Length - 1);
            }
        }

        static int Select(int[] array, int lowerBound, int m, int upperBound)
        {
            // Returns the value at index m (the median) in array slice A[l..h], 
                // if the slice were sorted into nondecreasing order.
            int pos = Partition(array, lowerBound, upperBound);

            stopwatch.Start();
            if (pos == m)
            {
                basicOperations++;
                stopwatch.Stop();
                return array[pos];
            }
            else if (pos > m)
            {
                basicOperations++;
                stopwatch.Stop();
                return Select(array, lowerBound, m, pos - 1);
            }
            else //pos < m
            {
                basicOperations++;
                stopwatch.Stop();
                return Select(array, pos + 1, m, upperBound);
            }
            
        }

        static int Partition(int[] _array, int lowerBound, int upperBound)
        {
            // Partitions array slice A[l..h] by moving element A[l] to the position
            // it would have if the array slice was sorted, and by moving all
            // values in the slice smaller than A[l] to earlier positions, and all values
            // larger than or equal to A[l] to later positions. Returns the index at which
            // the ‘pivot’ element formerly at location A[l] is placed.
            int[] array = _array;
            int pivotval = array[lowerBound]; //Pivot value is the first item in array slice.
            int pivotloc = lowerBound;

            //Loop through each item through the array slice
            //If iteration item is less than pivot value (the first item value in array slice), 
            //it increases pivotlocation (this is where it should be as of the current iteration)

            //Ultimately it places the pivot value at a position where all items to the left are smaller than it.
            for (int index = lowerBound + 1; index <= upperBound; index++)
            {
                if(pivotval > array[index])
                {
                    pivotloc += 1;

                    int indexItem = array[index];
                    array[index] = array[pivotloc];
                    array[pivotloc] = indexItem;
                    
                    //Note that the value of pivotloc isn't the location which contains the pivot value. It is where the pivot value should be as of the current iteration.
                    //Then the swap below places it there
                }
            }
            
            //Place pivot at final location (Now all items that are smaller than the pivot are to the left of it.
            int pivotValue = array[lowerBound];
            array[lowerBound] = array[pivotloc];
            array[pivotloc] = pivotValue;

            return pivotloc;
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
