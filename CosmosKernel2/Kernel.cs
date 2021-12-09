using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace PogOS
{
    public class Kernel : Sys.Kernel
    {
        public static String PogVer = "1.1";
        public static String Username = "root";
        protected override void BeforeRun()
        {
            
            Console.Clear();
            Console.WriteLine("Loading PogOS..");
        }

        protected override void Run()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Username);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("@PogOS $: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var Input = Console.ReadLine().Split(" ");
            if (Input[0].ToLower() == "print")
            {
                try
                {
                    foreach(String x in Input)
                    {
                        if (x.ToLower() != "print"){Console.Write(x+" ");}
                    }
                    Console.WriteLine("");
                }
                catch
                {
                    Console.WriteLine("Error.");
                }
            }

            if (Input[0].ToLower() == "sysinfo")
            {
                Console.WriteLine("PogOS Version: " + PogVer);
            }
            if (Input[0].ToLower() == "cls") {
                Console.Clear();
            }

        }
    }
}
