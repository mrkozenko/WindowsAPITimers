using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1Sys
{
    internal class CalcProcess
    {
        public static string calculation(double[,] arrayA, double[,] arrayB, double[,] arrayC)
        {
            var foundMax = FindMaxInArray(arrayA);
            var foundMin = FindMinInArray(arrayB);
            var foundAverage = FindAverageValue(arrayC);
            double[,] mainFormula = new double[arrayC.GetLength(0), arrayC.GetLength(1)];
            for (int i = 0; i < arrayC.GetLength(0); i++)
            {
                for (int j = 0; j < arrayC.GetLength(1); j++)
                {
                    mainFormula[i,j] = foundMax * arrayC[i,j]*foundMin - foundAverage + 0.942;
                }
            }
            var average_res = FindAverageValue(mainFormula);


            return $"Max value from array A - {foundMax}\n" +
                $"Min value from array B - {foundMin}\n" +
                $"Average value from array C - {foundAverage}\n" +
                $"Result of calculation and average value result array - {average_res}";
        }
        
        private static double FindMaxInArray(double[,] array)
        {
            double max = double.MinValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }
        private static double FindMinInArray(double[,] array)
        {
          
            double min = double.MaxValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }

            return min;
        }

        private static double FindAverageValue(double[,] arrayA)
        {
            double sum = 0.0;
            int count = 0;

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    sum += arrayA[i, j];
                    count++;
                }
            }

            return sum / count;
        }


    }
}
