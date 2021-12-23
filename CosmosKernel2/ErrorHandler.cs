using System;
using System.Collections.Generic;
using System.Text;
namespace PogOS
{
    class ErrorHandler
    {
        public static void CommandError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Unknown command.");
        }
        public static void EnvVarError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error setting enviornment variable.");
        }
    }
}
