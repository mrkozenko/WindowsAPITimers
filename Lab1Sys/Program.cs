using Lab1Sys.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1Sys
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Dictionary<int, int> arraySizes = new Dictionary<int, int>()
                {
                    { 600, 534 },
                    { 1500,600  },
                    { 2400, 1800 }
                };

 
            for (int i = 0; i < 3; i++)
            {
                var rows = arraySizes.ElementAt(i).Key;
                var cols = arraySizes.ElementAt(i).Value;

                Console.WriteLine($"\nArrays {rows}x{cols}");

                var filenameA = $"{rows}_{cols}A.txt";
                var filenameB = $"{rows}_{cols}B.txt";
                var filenameC = $"{rows}_{cols}C.txt";

              
                //Створення масивів і їх запис до файлів
                var arrayA = ReadWriteArrays.CreateFileArray(rows,cols, filenameA);
                var arrayB = ReadWriteArrays.CreateFileArray(rows, cols, filenameB);
                var arrayC = ReadWriteArrays.CreateFileArray(rows, cols, filenameC);

                //Отримання розміру файлу
                ReadWriteArrays.getFileSizeInBytes(filenameA);

                //Тестові функції для заміру часу, зчитування, обчислення, запису логу
                TestCases.TestCaseQueryTimer(arrayA, arrayB, arrayC);
                TestCases.TestCaseTimeGetTimeTimer(arrayA, arrayB, arrayC);
                TestCases.TestCaseThreadTimer(arrayA, arrayB, arrayC);

            }             

            Console.ReadLine();

        }
    }
}
