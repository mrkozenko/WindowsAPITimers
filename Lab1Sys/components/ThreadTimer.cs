using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1Sys
{
    public class ThreadTimer
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct FILETIME
        {
            public uint dwLowDateTime;
            public uint dwHighDateTime;
        }

        [DllImport("kernel32.dll")]
        private static extern bool GetThreadTimes(IntPtr hThread, out FILETIME lpCreationTime,
            out FILETIME lpExitTime, out FILETIME lpKernelTime, out FILETIME lpUserTime);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentThread();

        private FILETIME startKernelTime;
        private FILETIME startUserTime;

        private FILETIME endKernelTime;
        private FILETIME endUserTime;
        public double duration;
        public void Start()
        {
             
            GetThreadTimes(GetCurrentThread(), out _, out _, out startKernelTime, out startUserTime);
        }

        public void Stop()
        {
            GetThreadTimes(GetCurrentThread(), out _, out _, out endKernelTime, out endUserTime);
            long startTick = ((long)startKernelTime.dwHighDateTime << 32) + startKernelTime.dwLowDateTime +
                             ((long)startUserTime.dwHighDateTime << 32) + startUserTime.dwLowDateTime;

            long endTick = ((long)endKernelTime.dwHighDateTime << 32) + endKernelTime.dwLowDateTime +
                           ((long)endUserTime.dwHighDateTime << 32) + endUserTime.dwLowDateTime;

            duration = (endTick - startTick) * 1e-7;
        }

        
    }
}
