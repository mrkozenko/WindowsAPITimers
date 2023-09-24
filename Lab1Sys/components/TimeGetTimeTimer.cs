using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1Sys.components
{
    internal class TimeGetTimeTimer
    {
        [DllImport("winmm.dll", EntryPoint = "timeGetTime")]
        public static extern uint MM_GetTime();
        public double duration;
        private uint startTime;

        public void Start()
        {
            startTime = MM_GetTime();
        }

        public void Stop()
        {
            uint endTime = MM_GetTime();
            duration = (endTime - startTime) / 1000.0; // Повертаємо час в секундах
        }


    }
}
