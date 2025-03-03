using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            new Game { Date = new DateTime(2021, 1, 1), Score = 10, Type = GameType.Addition },
            new Game { Date = new DateTime(2021, 1, 2), Score = 20, Type = GameType.Subtraction },
            new Game { Date = new DateTime(2021, 1, 3), Score = 30, Type = GameType.Multiplication },
            new Game { Date = new DateTime(2021, 1, 4), Score = 40, Type = GameType.Division },
        };

        internal static void GetGames()
        {
            var gamesToPrint = games.Where(x => x.Score > 3);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("\n");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
            });
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var number1 = random.Next(1, 99);
            var number2 = random.Next(1, 99);
            var result = new int[2];

            while (number1 % number2 != 0)
            {
                number1 = random.Next(1, 99);
                number2 = random.Next(1, 99);
            }

            result[0] = number1;
            result[1] = number2;

            return result;
        }
    }
}