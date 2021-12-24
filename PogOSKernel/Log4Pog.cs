using System;
using System.Collections.Generic;
using System.Text;

namespace PogOS
{
    class Log4Pog
    {
        public static void LogOK(string message)
        {
            var time = DateTime.Now;
            Console.WriteLine("OK "+time.ToString() + " : " + message);
            Kernel.logs[Kernel.logs.Length + 1] = "OK " + time.ToString() + " : " + message;
        }
    }
}
