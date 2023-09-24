using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sys
{
    internal class ReadWriteArrays
    {
        public static void getFileSizeInBytes(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            Console.WriteLine($"{fileInfo.Length} bytes file size"); 
        }
        //Функція для запису логів
        public static void WriteLog(string filename, string text)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(text);
                writer.WriteLine("----------------");
                writer.WriteLine();
            }
        }
        //Функція для створення та запису масиву до вказаного файлу
        public static string CreateFileArray(int rows, int cols, string filename)
        {
            
            double[,] array = new double[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(array[i, j] + "\t"); // табуляція
                    }
                    writer.WriteLine(); 
                }
            }
            return filename;
        }

        //Функція для зчитування масиву зі вказаного файлу
        public static double[,] ReadArray(string filename)
        {
            string[] lines = File.ReadAllLines(filename);

            int rows = lines.Length;
            int cols = lines[0].Split('\t').Length - 1; // -1 тому що в кінці кожного рядка є додатковий символ табуляції

            double[,] array = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split('\t');

                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = double.Parse(values[j]);
                }
            }
            return array;
        }
        public static long GetFileSize(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            return fileInfo.Length; // returns the size of the file in bytes
        }

        public static void PrintLnArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
