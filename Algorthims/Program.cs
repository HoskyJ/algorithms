using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorthims
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            for (int y = 10; y <= 1000; y += 10)
            {
                int basicOperations = 0;
                double time = 0;

                for (int x = 0; x < 10; x++)
                {
                    int[] array = GenerateArray(y);

                    //BRUTE FORCE BASIC OPERATIONS//
                        //BruteForce.BruteForceMedian(array);
                        //basicOperations += BruteForce.GetBasicOperations();

                    //MEDIAN BASIC OPERATIONS//
                        //MedianAlgorithm.Median(array);
                        //basicOperations += MedianAlgorithm.GetBasicOperations();


                    //BRUTE FORCE TIME//
                        //BruteForce.BruteForceMedian(array);
                        //time += BruteForce.GetTime();

                    //MEDIAN TIME//
                        //MedianAlgorithm.Median(array);
                        //time += MedianAlgorithm.GetTime();
                }

                time /= 10; //Divide by number of tests per problem size to get average.
                Console.Write((time + "\n"));
            }
            Console.ReadLine();
        }

        //Generates and returns an array of given size.
        static int[] GenerateArray(int length)
        {
            int[] array = new int[length];
            for(int x = 0; x < length; x++)
            {
                array[x] = rnd.Next(1, 200);
            }
            return array;
        }
    }
}
