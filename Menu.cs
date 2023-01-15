namespace MathGame;

public static class Menu
{
    internal static void ShowMenu(string? name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Hello {name}. It is {date.DayOfWeek}. Let's practice some math.\n\n");

        var isPlaying = true;

        do
        {
            var gameSelected = Helpers.ChooseGameType();

            switch (gameSelected)
            {
                case "v":
                    Helpers.GetScores();
                    break;
                case "a":
                    GameEngine.AdditionGame("Addition game", Helpers.SetDifficulty('a'));
                    break;
                case "s":
                    GameEngine.SubtractionGame("Subtraction game", Helpers.SetDifficulty('s'));
                    break;
                case "m":
                    GameEngine.MultiplicationGame("Multiplication game", Helpers.SetDifficulty('m'));
                    break;
                case "d":
                    GameEngine.DivisionGame("Division game", Helpers.SetDifficulty('d'));
                    break;
                case "q":
                    Console.Clear();
                    Console.WriteLine("Goodbye\n");
                    isPlaying = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input\n");
                    break;
            }
        } while (isPlaying);
    }
}