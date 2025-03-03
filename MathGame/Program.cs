using System.Numerics;
using System.Threading.Tasks.Sources;
using MathGame;

/*define variable to import menu class*/
var menu = new Menu();

/* define variable for today's date*/
var date = DateTime.UtcNow;

/*define variable to store history of games played*/
var games = new List<string>();

/* define variable for user's name input by assigning it GetName method*/
string name = GetName();

/*Call method for menu options*/
menu.ShowMenu(name, date);

/*Create method for user's name input*/
string GetName()
{
    Console.WriteLine("Please type your name:");
    var name = Console.ReadLine()!;
    return name;
}