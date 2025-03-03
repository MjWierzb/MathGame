namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            /* use name and date variables to present custom message*/
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is my first program, a math game selector.");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                /* math game options*/
                Console.Clear();
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                    A - Addition
                    S - Subtraction
                    M - Multiplication
                    D - Division
                    V - View history of games played
                    Q - Quit the program");

                Console.WriteLine("\n");

                /* once menu option is chosen, run method associated with it*/
                var gameSelected = Console.ReadLine()!;
                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "q":
                        gameEngine.QuitGame("Quiting the program");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            } while (isGameOn);
        }
    }
}