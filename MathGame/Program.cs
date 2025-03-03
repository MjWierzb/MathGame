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
string name = Helpers.GetName();

/*Call method for menu options*/
menu.ShowMenu(name, date);