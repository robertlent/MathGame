namespace MathGame;

public static class Menu
{
    internal static void ShowMenu(string? s, DateTime date)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Hello {s}. It is {date.DayOfWeek}. This is your math game.\n\n");
        var isPlaying = true;

        do
        {
            Console.WriteLine(@"What game would you like to play today?

            V - View Previous Scores
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            Q - Quit the program");

            Console.WriteLine("\n--------------------------------------------------");

            var gameSelected = Console.ReadLine();

            switch (gameSelected?.ToLower().Trim())
            {
                case "v":
                    Helpers.GetScores();
                    break;
                case "a":
                    GameEngine.AdditionGame("Addition game");
                    break;
                case "s":
                    GameEngine.SubtractionGame("Subtraction game");
                    break;
                case "m":
                    GameEngine.MultiplicationGame("Multiplication game");
                    break;
                case "d":
                    GameEngine.DivisionGame("Division game");
                    break;
                case "q":
                    Console.Clear();
                    Console.WriteLine("Goodbye");
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