using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();
            int secretNumber = randomNumberGenerator.Next(1, 101);
            Console.WriteLine("Please enter a difficulty level: Easy, Medium, Hard");
            string difficultyLevel = Console.ReadLine();
            Console.WriteLine("Please guess a number!!");
            int numGuesses = 0;
            if (difficultyLevel == "Easy")
                {
                    numGuesses = 8;
                }
                else if (difficultyLevel == "Medium")
                {
                    numGuesses = 6;
                }
                else if (difficultyLevel == "Hard")
                {
                    numGuesses = 4;
                }
                else
                {
                    Console.WriteLine("Please enter one of the choices");
                    
                }
            for (int i = 0; i < numGuesses; i++)
                {     
                string guess = Console.ReadLine();
                int intGuess = int.Parse(guess);
                Console.Write($"Your guess ({ numGuesses - i })>");
                if (intGuess == secretNumber) {

                    Console.WriteLine("You got it right, you are amazing");
                    break;
                } 
                else if (intGuess > secretNumber){
                    Console.WriteLine("Guess is too high");
                }
                else //if (intGuess < secretNumber)
                {
                    Console.WriteLine("Guess is too low");
                }
            }
        }
    }
}
