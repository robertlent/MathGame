using MathGame.Models;

namespace MathGame;

public static class Helpers
{
    internal static string GetName()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please type your name:");
            var input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input)) return input;
        }
    }

    internal static string ChooseGameType()
    {
        Console.WriteLine(@"What game would you like to play today?

        V - View Previous Scores
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        Q - Quit the program");

        Console.WriteLine("\n--------------------------------------------------");

        return Console.ReadLine()?.ToLower().Trim() ?? string.Empty;
    }

    internal static int SetDifficulty(char type)
    {
        var input = "";
        int difficulty;

        do
        {
            do
            {
                Console.Clear();
                Console.WriteLine(type != 'd'
                    ? @"Choose a difficulty (1-5):

            1) Give Me (Basics) - operation uses numbers between 1 and 10
            2) Give Me (Grace) - operation uses numbers between 1 and 100
            3) Give Me (Balance) - operation uses numbers between 1 and 1000
            4) Give Me (No Mercy) - operation uses numbers between 1 and 10000
            5) Give Me (God of Math) - operation uses numbers between 1 and 100000"
                    : @"Choose a difficulty (1-5):

            1) Give Me (Basics) - operation uses numbers between 1 and 100
            2) Give Me (Grace) - operation uses numbers between 1 and 1000
            3) Give Me (Balance) - operation uses numbers between 1 and 10000
            4) Give Me (No Mercy) - operation uses numbers between 1 and 100000
            5) Give Me (God of Math) - operation uses numbers between 1 and 1000000");

                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input) || !int.TryParse(input, out _));

            difficulty = int.Parse(input);
        } while (difficulty is <= 0 or > 5);

        if (type != 'd')
            return difficulty switch
            {
                1 => 10,
                2 => 100,
                3 => 1000,
                4 => 10000,
                _ => 100000
            };
        else
            return difficulty switch
            {
                1 => 100,
                2 => 1000,
                3 => 10000,
                4 => 100000,
                _ => 1000000
            };
    }

    internal static List<Game> games = new();

    internal static void GetScores()
    {
        Console.Clear();
        Console.WriteLine("Previous Scores");
        Console.WriteLine("--------------------------------------------------");

        foreach (var game in games) Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} points");

        Console.WriteLine("--------------------------------------------------\n");
        Console.WriteLine("Press any key to go back to the main menu.");
        Console.ReadLine();
        Console.Clear();
    }

    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType
        });
    }

    internal static int[] GetDivisionNumbers(int max)
    {
        var random = new Random();
        var firstNumber = random.Next(1, max);
        var secondNumber = random.Next(1, max);
        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, max);
            secondNumber = random.Next(1, max);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }
}