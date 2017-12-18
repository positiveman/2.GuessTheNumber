using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 88;


            while (true)
            {
                Console.Write("Guess the number:\n");
                int guess = int.Parse(Console.ReadLine());
                if (guess < number)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Too low...");
                }
                else if (guess > number)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Too high...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("You're right!\n");
                    break;
                }


            }
        }
    }
}
