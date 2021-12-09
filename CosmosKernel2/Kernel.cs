using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace PogOS
{
    public class Kernel : Sys.Kernel
    {
        public static String PogVer = "1.0";
        protected override void BeforeRun()
        {
            
            Console.WriteLine("Loading PogOS..");
        }

        protected override void Run()
        {
            Console.Write("PogOS $: ");
            var Input = Console.ReadLine().Split(" ");
            if(Input[0].ToLower() == "print")
            {
                try
                {
                    foreach(String x in Input)
                    {
                        if (x != "print"){Console.Write(x);}
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
        }
    }
}
