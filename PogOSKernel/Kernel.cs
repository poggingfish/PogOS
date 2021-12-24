using System;
using System.Collections.Generic;
using Sys = Cosmos.System;
using Cosmos.HAL;
using PogOS;
namespace PogOS
    /*
     * Pog Os
     * -Dylan 2021
     */
{
    public class Kernel : Sys.Kernel
    {
    
        public string PogVer;
        public string Username = "";
        public static Dictionary<string, string> env_vars = new Dictionary<string,string>();
        protected override void BeforeRun()
        {
            PogVer = "1.31";
            Console.Clear();            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Loading PogOS "+PogVer+".");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("What is your name: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Username = Console.ReadLine().Replace(' ', '-');
            Console.WriteLine(">======>                                  >===>        >=>>=>");
            Console.WriteLine(">=>    >=>                              >=>    >=>   >=>    >=>");
            Console.WriteLine(">=>    >=>    >=>        >=>          >=>        >=>  >=>");
            Console.WriteLine(">======>    >=>  >=>   >=>  >=>       >=>        >=>    >=>");
            Console.WriteLine(">=>        >=>    >=> >=>   >=>       >=>        >=>       >=>");
            Console.WriteLine(">=>         >=>  >=>   >=>  >=>         >=>     >=>  >=>    >=>");
            Console.WriteLine(">=>           >=>          >=>            >===>        >=>>=>");
            Console.WriteLine("                        >=>                                  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(">=>>=>                    >====>                >=>");
            Console.WriteLine(">>   >=>                  >=>   >=>             >=>");
            Console.WriteLine(">>    >=> >=>   >=>       >=>    >=> >=>   >=>  >=>    >=> >=>  >==>>==>");
            Console.WriteLine(">==>>=>    >=> >=>        >=>    >=>  >=> >=>   >=>  >=>   >=>   >=>  >=>");
            Console.WriteLine(">>    >=>    >==>         >=>    >=>    >==>    >=> >=>    >=>   >=>  >=>");
            Console.WriteLine(">>     >>     >=>         >=>   >=>      >=>    >=>  >=>   >=>   >=>  >=>");
            Console.WriteLine(">===>>=>     >=>          >====>        >=>    >==>   >==>>>==> >==>  >=>");
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
            var Input = Console.ReadLine().Split(" ");
            if (Input[0].ToLower() == "print")
            {
                try
                {
                    foreach (String x in Input)
                    {
                        if (x.ToLower() != "print") {
                            try
                            {
                                Console.Write(env_vars[x].ToString() + " ");
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
                Console.WriteLine("PogOS Version: " + PogVer);
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
                Username = Console.ReadLine();
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
            else if (Input[0].ToLower() == "set"){
                string fullstr = "";
                int iter = 0;
                try
                {
                    foreach (var x in Input)
                    {
                        if (x != Input[0])
                        {
                            iter++;
                            if (iter > 1)
                            {
                                fullstr += x+" ";
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
                catch
                {
                    ErrorHandler.EnvVarError();
                }
                }
            else if (Input[0].ToLower() == "resetres")
            {
                
            }
            else
            {
                ErrorHandler.CommandError();
            }

        }

    }
}
