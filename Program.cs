using System;

namespace Guessing_Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random number = new Random();

            int rightNum = number.Next(0 , 5);

            bool won = false;

            do
            {
                try
                {
                    Console.Write("Guess a number between 0 and 5:");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == rightNum)
                    {
                        Console.WriteLine("Congrats! u guessed the num.");
                        won = true;
                        Console.ReadLine(); //Waits for input so that Terminal doesn't close 
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Enter Number urod.");
                }
            }while (!won);
        }
    }
}
