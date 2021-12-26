#region using
using System;
using System.Collections.Generic;
using Sys = Cosmos.System;
using Cosmos.Core;
namespace PogOS
/*
 * Pog Os
 * -Dylan 2021
 */
#endregion

{
    public class Kernel : Sys.Kernel
    {
        public static String PogVer;
        public static String Username = "PogFish";
        public static Dictionary<string, string> env_vars = new Dictionary<string,string>();
        protected override void BeforeRun()
        {
            Log4Pog.LogOK("Init.");
            PogVer = "Alpha v1.31";
            Console.Clear();            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Loading PogOS "+PogVer+".");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("What is your name: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Username = Console.ReadLine().Replace(' ', '-');
            logo.printlogo();
            Enviornment.set_env("user", Username);
            Log4Pog.LogOK("Set enviornemnt variables");
            Log4Pog.LogOK("Succesfully booted.");
        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Username + "@");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("PogOS $: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            String Input = Console.ReadLine();
            shell.runcommand(Input);            
        }

    }
}
