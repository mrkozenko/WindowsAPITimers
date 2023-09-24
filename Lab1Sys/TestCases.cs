using Lab1Sys.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sys
{
    internal class TestCases
    {
        public static void TestCaseQueryTimer(string filenameA, string filenameB, string filenameC)
        {
            Console.WriteLine("\nQueryPerfomanceTimer:");
            double[,] arrayA ;
            double[,] arrayB ;
            double[,] arrayC ;
            string result;

            QueryPerfomanceTimer timerPerfomanceGlobal = new QueryPerfomanceTimer();
            QueryPerfomanceTimer timerPerfomancelocalReading = new QueryPerfomanceTimer();
            QueryPerfomanceTimer timerPerfomancelocalCalculation = new QueryPerfomanceTimer();
            QueryPerfomanceTimer timerPerfomancelocalWriterLogs = new QueryPerfomanceTimer();

            timerPerfomanceGlobal.Start();
            timerPerfomancelocalReading.Start();
            arrayA = ReadWriteArrays.ReadArray($"{filenameA}");
            arrayB = ReadWriteArrays.ReadArray($"{filenameB}");
            arrayC = ReadWriteArrays.ReadArray($"{filenameC}");
            timerPerfomancelocalReading.Stop();
            Console.WriteLine($" - reading time {timerPerfomancelocalReading.Duration} seconds");
            timerPerfomancelocalCalculation.Start();
            result = CalcProcess.calculation(arrayA, arrayB, arrayC);
            timerPerfomancelocalCalculation.Stop();
            Console.WriteLine($" - calculation time {timerPerfomancelocalCalculation.Duration} seconds");
            timerPerfomancelocalWriterLogs.Start();
            ReadWriteArrays.WriteLog("nQueryPerfomanceTimer.txt", result);
            timerPerfomancelocalWriterLogs.Stop();
            Console.WriteLine($" - write logs time {timerPerfomancelocalWriterLogs.Duration} seconds");
            timerPerfomanceGlobal.Stop();
            Console.WriteLine($"--------------\nClear full time {timerPerfomanceGlobal.Duration} seconds");
        }


        public static void TestCaseTimeGetTimeTimer(string filenameA, string filenameB, string filenameC)
        {
            Console.WriteLine("\nTimeGetTimeTimer:");
            double[,] arrayA;
            double[,] arrayB;
            double[,] arrayC;
            string result;

            TimeGetTimeTimer timeGetTimeTimerGlobal = new TimeGetTimeTimer();
            TimeGetTimeTimer timeGetTimeTimerlocalReading = new TimeGetTimeTimer();
            TimeGetTimeTimer timeGetTimeTimerlocalCalculation = new TimeGetTimeTimer();
            TimeGetTimeTimer timeGetTimeTimerlocalWriterLogs = new TimeGetTimeTimer();

            timeGetTimeTimerGlobal.Start();
            timeGetTimeTimerlocalReading.Start();
            arrayA = ReadWriteArrays.ReadArray($"{filenameA}");
            arrayB = ReadWriteArrays.ReadArray($"{filenameB}");
            arrayC = ReadWriteArrays.ReadArray($"{filenameC}");
            timeGetTimeTimerlocalReading.Stop();
            Console.WriteLine($" - reading time {timeGetTimeTimerlocalReading.duration} seconds");
            timeGetTimeTimerlocalCalculation.Start();
            result = CalcProcess.calculation(arrayA, arrayB, arrayC);
            timeGetTimeTimerlocalCalculation.Stop();
            Console.WriteLine($" - calculation time {timeGetTimeTimerlocalCalculation.duration} seconds");
            timeGetTimeTimerlocalWriterLogs.Start();
            ReadWriteArrays.WriteLog("TimeGetTimeTimer.txt", result);
            timeGetTimeTimerlocalWriterLogs.Stop();
            Console.WriteLine($" - write logs time {timeGetTimeTimerlocalWriterLogs.duration} seconds");
            timeGetTimeTimerGlobal.Stop();
            Console.WriteLine($"--------------\nClear full time {timeGetTimeTimerGlobal.duration} seconds");
        }

        public static void TestCaseThreadTimer(string filenameA, string filenameB, string filenameC)
        {
            Console.WriteLine("\nThreadTimer:");
            double[,] arrayA;
            double[,] arrayB;
            double[,] arrayC;
            string result;

            ThreadTimer ThreadTimerGlobal = new ThreadTimer();
            ThreadTimer ThreadTimerlocalReading = new ThreadTimer();
            ThreadTimer ThreadTimerlocalCalculation = new ThreadTimer();
            ThreadTimer ThreadTimerlocalWriterLogs = new ThreadTimer();

            ThreadTimerGlobal.Start();
            ThreadTimerlocalReading.Start();
            arrayA = ReadWriteArrays.ReadArray($"{filenameA}");
            arrayB = ReadWriteArrays.ReadArray($"{filenameB}");
            arrayC = ReadWriteArrays.ReadArray($"{filenameC}");
            ThreadTimerlocalReading.Stop();
            Console.WriteLine($" - reading time {ThreadTimerlocalReading.duration} seconds");
            ThreadTimerlocalCalculation.Start();
            result = CalcProcess.calculation(arrayA, arrayB, arrayC);
            ThreadTimerlocalCalculation.Stop();
            Console.WriteLine($" - calculation time {ThreadTimerlocalCalculation.duration} seconds");
            ThreadTimerlocalWriterLogs.Start();
            ReadWriteArrays.WriteLog("ThreadTimer.txt", result);
            ThreadTimerlocalWriterLogs.Stop();
            Console.WriteLine($" - write logs time {ThreadTimerlocalWriterLogs.duration} seconds");
            ThreadTimerGlobal.Stop();
            Console.WriteLine($"--------------\nClear full time {ThreadTimerGlobal.duration} seconds");
        }
    }
}
