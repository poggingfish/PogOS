using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.Core;

namespace PogOS
{
    class shell
    {
        public static void runcommand(string InputVar)
        {
            var Input = InputVar.Split(" ");
            if (Input[0].ToLower() == "print")
            {
                try
                {
                    foreach (String x in Input)
                    {
                        if (x.ToLower() != "print")
                        {
                            try
                            {
                                Console.Write(Kernel.env_vars[x].ToString() + " ");
                            }
                            catch
                            {
                                Console.Write(x + " ");
                            }

                        }
                    }
                    Console.WriteLine("");
                }
                catch
                {
                    ErrorHandler.GenericError("");
                }
            }

            else if (Input[0].ToLower() == "sysinfo")
            {
                Console.WriteLine("PogOS Version: " + Kernel.PogVer);
            }
            else if (Input[0].ToLower() == "cls" || Input[0].ToLower() == "clear")
            {
                Console.Clear();
            }
            else if (Input[0].ToLower() == "changename")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("What is your name: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Kernel.Username = Console.ReadLine();
            }
            else if (Input[0].ToLower() == "date")
            {
                var time = DateTime.Now;
                Console.WriteLine(time);
            }
            else if (Input[0].ToLower() == "notepad")
            {
                Console.WriteLine("Press exit to exit.");
                while (true)
                {
                    var input2 = Console.ReadLine();
                    if (input2 == "exit")
                    {
                        break;
                    }
                }
            }
            else if (Input[0].ToLower() == "set")
            {
                string fullstr = "";
                int iter = 0;
                foreach (var x in Input)
                {
                    if (x != Input[0])
                    {
                        iter++;
                        if (iter > 1)
                        {
                            fullstr += x + " ";
                        }
                    }
                }
                try
                {
                    Enviornment.remove_env(Input[1]);
                }
                catch
                {
                }
                Enviornment.set_env(Input[1], fullstr);

            }
            else if (Input[0].ToLower() == "sysinfo")
            {
                Console.WriteLine("OS Version: " + Kernel.PogVer);
                Console.WriteLine("Memory: " + CPU.GetAmountOfRAM() + "MB");
                Console.WriteLine("Shell: " + "PogOS Shell");
            }
            else if (Input[0].ToLower() == "guessnumber")
            {
                try {PogOS.games.GuessTheNumber.game(Int16.Parse(Input[1]));}
                catch{ ErrorHandler.GenericError("Did you enter a number?"); }
            }

            else
            {
                ErrorHandler.CommandError();
            }
        }
    }
}
