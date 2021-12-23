using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace PogOS
{
    public class Kernel : Sys.Kernel
    {

        public static String PogVer = "1.2";
        public static String Username = "";
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
                        if (x.ToLower() != "print") { Console.Write(x + " "); }
                    }
                    Console.WriteLine("");
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
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unknown command.");
            }

        }
    }
}
