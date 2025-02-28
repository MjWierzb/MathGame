using System.Numerics;
using System.Threading.Tasks.Sources;

/* define variable for today's date*/
var date = DateTime.UtcNow;

/* define variable for user's name input by assigning it GetName method*/
string name = GetName();

Console.WriteLine("----------------------");

/*Call method for menu options*/
Menu(name);

/*Create method for user's name input*/
string GetName()
{
    Console.WriteLine("Please type your name:");
    var name = Console.ReadLine();
    return name;
}

/*Create method for Menu options*/
void Menu(string name)
{
    /* use name and date variables to present custom message*/
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is my first program, a math game selector.");

    Console.WriteLine();

    /* math game options*/
    Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");

    Console.WriteLine("----------------------");

    /* once menu option is chosen, run method associated with it*/
    var gameSelected = Console.ReadLine();
    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game");
            break;
        case "s":
            SubtractionGame("Subtraction game");
            break;
        case "m":
            MultiplicationGame("Multiplication game");
            break;
        case "d":
            DivisionGame("Division game");
            break;
        case "q":
            QuitGame("Quiting the program");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid option selected");
            Environment.Exit(1);
            break;
    }
}

/* addition game code*/
void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int number1;
    int number2;

    for(int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        number1 = random.Next(1, 9);
        number2 = random.Next(1, 9);

        Console.WriteLine($"{number1} + {number2}");
        var result = Console.ReadLine();

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
            Console.WriteLine($"You have completed the game. Your final score was {score} points!");
        }
    }
}

/* subtraction game code*/
void SubtractionGame(string message)
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
        var result = Console.ReadLine();

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
            Console.WriteLine($"You have completed the game. Your final score was {score} points!");
        }
    }
}

/* multiplication game code*/
void MultiplicationGame(string message)
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
        var result = Console.ReadLine();

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
            Console.WriteLine($"You have completed the game. Your final score was {score} points!");
        }
    }
}

/* division game code*/
void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var number1 = divisionNumbers[0];
        var number2 = divisionNumbers[1];

        Console.WriteLine($"{number1} / {number2}");
        var result = Console.ReadLine();

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
            Console.WriteLine($"You have completed the game. Your final score was {score} points!");
        }
    }
}
/* quit game code*/
void QuitGame(string message)
{
    Console.WriteLine(message);
}

/*create method for division game code*/
int[] GetDivisionNumbers()
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