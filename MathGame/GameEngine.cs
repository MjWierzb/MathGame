using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int number1;
            int number2;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                number1 = random.Next(1, 9);
                number2 = random.Next(1, 9);

                Console.WriteLine($"{number1} + {number2}");
                var result = Console.ReadLine()!;

                result = Helpers.ValidateResult(result);
                
                if (int.Parse(result) == number1 + number2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                }

                if (i == 4)
                {
                    Console.WriteLine($"You have completed the game. Your final score was {score} points! Press any key to go back to the main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int number1;
            int number2;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                number1 = random.Next(1, 9);
                number2 = random.Next(1, 9);

                Console.WriteLine($"{number1} - {number2}");
                var result = Console.ReadLine()!;

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == number1 - number2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                }

                if (i == 4)
                {
                    Console.WriteLine($"You have completed the game. Your final score was {score} points! Press any key to go back to the main menu");
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int number1;
            int number2;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                number1 = random.Next(1, 9);
                number2 = random.Next(1, 9);

                Console.WriteLine($"{number1} * {number2}");
                var result = Console.ReadLine()!;

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == number1 * number2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                }

                if (i == 4)
                {
                    Console.WriteLine($"You have completed the game. Your final score was {score} points! Press any key to go back to the main menu");
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var number1 = divisionNumbers[0];
                var number2 = divisionNumbers[1];

                Console.WriteLine($"{number1} / {number2}");
                var result = Console.ReadLine()!;

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == number1 / number2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"You have completed the game. Your final score was {score} points! Press any key to go back to the main menu");
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void QuitGame(string message)
        {
            Console.WriteLine(message);
        }
    }
}