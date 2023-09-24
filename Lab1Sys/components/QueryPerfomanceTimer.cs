using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1Sys.components
{
    internal class QueryPerfomanceTimer
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(
           out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(
            out long lpFrequency);

        private long startTime, stopTime;
        private long freq;
        public double Duration;
        public QueryPerfomanceTimer()
        {
            startTime = 0;
            stopTime = 0;

            if (QueryPerformanceFrequency(out freq) == false)
            {
                throw new Win32Exception();
            }
         
        }
     
        public void Start()
        {

            QueryPerformanceCounter(out startTime);
        }

        public void Stop()
        {
            Thread.Sleep(1);

            QueryPerformanceCounter(out stopTime);
            Duration = (double)(stopTime - startTime) / (double)freq;

        }

       
    }
}
