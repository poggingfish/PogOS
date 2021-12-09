using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace PogOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Loading PogOS..");
        }

        protected override void Run()
        {
            Console.Write("$: ");
            var Input = Console.ReadLine().Split(" ");
            if(Input[0].ToLower() == "hello")
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
