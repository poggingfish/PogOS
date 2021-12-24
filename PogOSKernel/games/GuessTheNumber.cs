using System;
using System.Collections.Generic;
using System.Text;
namespace PogOS.games
{
    class GuessTheNumber
    {
        public static void game(int max){
            Random rnd = new Random();
            int number = rnd.Next(max);
            int guesses=0;
            string guess = "-1";
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                while (Int16.Parse(guess) != number)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    if (Int16.Parse(guess) < number)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                    if (Int16.Parse(guess) > number)
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                    guesses++;
                    if (Int16.Parse(guess) == number)
                    {
                        Console.WriteLine("You got it in " + guesses + " guesses");
                    }
                }
            }
            catch
            {
                ErrorHandler.GenericError("Are you sure you entered a number?");
            }
        }
    }
}
