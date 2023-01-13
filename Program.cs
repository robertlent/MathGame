using MathGame;

var name = GetName();
var date = DateTime.UtcNow;

Menu.ShowMenu(name, date);

string? GetName()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Please type your name:");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input)) return input;
    }
}