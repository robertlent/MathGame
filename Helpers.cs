namespace MathGame;

public static class Helpers
{
    private static List<string> games = new();

    internal static void GetScores()
    {
        Console.Clear();
        Console.WriteLine("Previous Scores");
        Console.WriteLine("--------------------------------------------------");

        foreach (var game in games) Console.WriteLine(game);

        Console.WriteLine("--------------------------------------------------\n");
        Console.WriteLine("Press any key to go back to the main menu.");
        Console.ReadLine();
    }

    internal static void AddToHistory(int gameScore, string gameType)
    {
        games.Add($"{DateTime.Now} - {gameType} : {gameScore} points");
    }

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 100);
        var secondNumber = random.Next(1, 100);
        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 100);
            secondNumber = random.Next(1, 100);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }
}