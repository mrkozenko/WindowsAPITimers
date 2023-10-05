using Lab1Sys.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1Sys
{
    internal class TestCases
    {
        public static void TestCaseQueryTimer(string filenameA, string filenameB, string filenameC)
        {
            Console.WriteLine("\nQueryPerfomanceTimer:");
            double[,] arrayA = null;
            double[,] arrayB = null;
            double[,] arrayC = null;
            string result = null;

            QueryPerfomanceTimer timerPerfomanceGlobal = new QueryPerfomanceTimer();
            QueryPerfomanceTimer timerPerfomancelocalReading = new QueryPerfomanceTimer();
            QueryPerfomanceTimer timerPerfomancelocalCalculation = new QueryPerfomanceTimer();
            QueryPerfomanceTimer timerPerfomancelocalWriterLogs = new QueryPerfomanceTimer();

            timerPerfomanceGlobal.Start();
            timerPerfomancelocalReading.Start();

            Thread threadA = new Thread(() => { arrayA = ReadWriteArrays.ReadArray($"{filenameA}"); });
            Thread threadB = new Thread(() => { arrayB = ReadWriteArrays.ReadArray($"{filenameB}"); });
            Thread threadC = new Thread(() => { arrayC = ReadWriteArrays.ReadArray($"{filenameC}"); });

            threadA.Start();
            threadB.Start();
            threadC.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();

            timerPerfomancelocalReading.Stop();
            Console.WriteLine($" - reading time {timerPerfomancelocalReading.Duration} seconds");

            timerPerfomancelocalCalculation.Start();

            Thread calculationThread = new Thread(() => { result = CalcProcess.calculation(arrayA, arrayB, arrayC); });
            calculationThread.Start();

            timerPerfomancelocalCalculation.Stop();
            Console.WriteLine($" - calculation time {timerPerfomancelocalCalculation.Duration} seconds");

            timerPerfomancelocalWriterLogs.Start();

            Thread writerThread = new Thread(() => { ReadWriteArrays.WriteLog("nQueryPerfomanceTimer.txt", result); });
            writerThread.Start();

            timerPerfomancelocalWriterLogs.Stop();
            Console.WriteLine($" - write logs time {timerPerfomancelocalWriterLogs.Duration} seconds");

            timerPerfomanceGlobal.Stop();
            Console.WriteLine($"--------------\nClear full time {timerPerfomanceGlobal.Duration} seconds");
        }


        public static void TestCaseTimeGetTimeTimer(string filenameA, string filenameB, string filenameC)
        {
            Console.WriteLine("\nTimeGetTimeTimer:");
            double[,] arrayA = null;
            double[,] arrayB = null;
            double[,] arrayC = null;
            string result = null;

            TimeGetTimeTimer timeGetTimeTimerGlobal = new TimeGetTimeTimer();
            TimeGetTimeTimer timeGetTimeTimerlocalReading = new TimeGetTimeTimer();
            TimeGetTimeTimer timeGetTimeTimerlocalCalculation = new TimeGetTimeTimer();
            TimeGetTimeTimer timeGetTimeTimerlocalWriterLogs = new TimeGetTimeTimer();

            timeGetTimeTimerGlobal.Start();
            timeGetTimeTimerlocalReading.Start();
            Thread threadA = new Thread(() => { arrayA = ReadWriteArrays.ReadArray($"{filenameA}"); });
            Thread threadB = new Thread(() => { arrayB = ReadWriteArrays.ReadArray($"{filenameB}"); });
            Thread threadC = new Thread(() => { arrayC = ReadWriteArrays.ReadArray($"{filenameC}"); });

            threadA.Start();
            threadB.Start();
            threadC.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            timeGetTimeTimerlocalReading.Stop();
            Console.WriteLine($" - reading time {timeGetTimeTimerlocalReading.duration} seconds");
            timeGetTimeTimerlocalCalculation.Start();
            Thread calculationThread = new Thread(() => { result = CalcProcess.calculation(arrayA, arrayB, arrayC); });
            calculationThread.Start();
            timeGetTimeTimerlocalCalculation.Stop();
            Console.WriteLine($" - calculation time {timeGetTimeTimerlocalCalculation.duration} seconds");
            timeGetTimeTimerlocalWriterLogs.Start();
            Thread writerThread = new Thread(() => { ReadWriteArrays.WriteLog("TimeGetTimeTimer.txt", result); });
            writerThread.Start();
            timeGetTimeTimerlocalWriterLogs.Stop();
            Console.WriteLine($" - write logs time {timeGetTimeTimerlocalWriterLogs.duration} seconds");
            timeGetTimeTimerGlobal.Stop();
            Console.WriteLine($"--------------\nClear full time {timeGetTimeTimerGlobal.duration} seconds");
        }

        public static void TestCaseThreadTimer(string filenameA, string filenameB, string filenameC)
        {
            Console.WriteLine("\nThreadTimer:");
            double[,] arrayA = null;
            double[,] arrayB = null;
            double[,] arrayC = null;
            string result = null;

            ThreadTimer ThreadTimerGlobal = new ThreadTimer();
            ThreadTimer ThreadTimerlocalReading = new ThreadTimer();
            ThreadTimer ThreadTimerlocalCalculation = new ThreadTimer();
            ThreadTimer ThreadTimerlocalWriterLogs = new ThreadTimer();

            ThreadTimerGlobal.Start();
            ThreadTimerlocalReading.Start();
            Thread threadA = new Thread(() => { arrayA = ReadWriteArrays.ReadArray($"{filenameA}"); });
            Thread threadB = new Thread(() => { arrayB = ReadWriteArrays.ReadArray($"{filenameB}"); });
            Thread threadC = new Thread(() => { arrayC = ReadWriteArrays.ReadArray($"{filenameC}"); });

            threadA.Start();
            threadB.Start();
            threadC.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            ThreadTimerlocalReading.Stop();
            Console.WriteLine($" - reading time {ThreadTimerlocalReading.duration} seconds");
            ThreadTimerlocalCalculation.Start();
            Thread calculationThread = new Thread(() => { result = CalcProcess.calculation(arrayA, arrayB, arrayC); });
            calculationThread.Start();
            ThreadTimerlocalCalculation.Stop();
            Console.WriteLine($" - calculation time {ThreadTimerlocalCalculation.duration} seconds");
            ThreadTimerlocalWriterLogs.Start();
            Thread writerThread = new Thread(() => { ReadWriteArrays.WriteLog("ThreadTimer.txt", result); });
            writerThread.Start();
            ThreadTimerlocalWriterLogs.Stop();
            Console.WriteLine($" - write logs time {ThreadTimerlocalWriterLogs.duration} seconds");
            ThreadTimerGlobal.Stop();
            Console.WriteLine($"--------------\nClear full time {ThreadTimerGlobal.duration} seconds");
        }
    }
}
