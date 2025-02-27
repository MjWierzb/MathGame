using System.Numerics;

Console.WriteLine("Please type your name:");

/* define variable for user's name*/ string name = Console.ReadLine();
/* define variable for today's date*/ var date = DateTime.UtcNow;

Console.WriteLine("----------------------");
/* use name and date variables to present custom message*/ Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is my first program, a math game selector.");
Console.WriteLine();
/* math game options*/ Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("----------------------");

/* once menu option is chosen, run method associated with it*/ var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame();
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame();
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame();
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame();
}
else if (gameSelected.Trim().ToLower() == "q")
{
    QuitGame();
}
else
{
    Console.WriteLine("Invalid option selected");
}
/* addition game code*/ void AdditionGame()
{
    Console.WriteLine("Addition game selected");
}
/* subtraction game code*/
void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected");
}
/* multiplication game code*/
void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected");
}
/* division game code*/
void DivisionGame()
{
    Console.WriteLine("Division game selected");
}
/* quit game code*/
void QuitGame()
{
    Console.WriteLine("Quitting the program");
}