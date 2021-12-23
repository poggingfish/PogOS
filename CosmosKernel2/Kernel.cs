using System;
using System.Collections.Generic;
using Sys = Cosmos.System;
using PogOS;
namespace PogOS
{
    public class Kernel : Sys.Kernel
    {

        public static String PogVer = "1.3";
        public static String Username = "";
        public static Dictionary<string, string> env_vars = new Dictionary<string,string>();
        protected override void BeforeRun()
        {
            Console.Clear();            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Loading PogOS "+PogVer+".");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("What is your name: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Username = Console.ReadLine();
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
                                Console.WriteLine(env_vars[x]);
                            }
                            catch
                            {
                                Console.WriteLine(x);
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error.");
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
                try
                {
                    env_vars.Add(Input[1],Input[2]);
                }
                catch
                {
                    ErrorHandler.EnvVarError();
                }
                }
            else
            {
                ErrorHandler.CommandError();
            }

        }

    }
}
