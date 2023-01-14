using MathGame.Models;
namespace MathGame;

public static class GameEngine
{
    internal static void AdditionGame(string message)
    {
        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);
            var result = "";

            do
            {
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} + {secondNumber}");

                result = Console.ReadLine();
            } while (result == "" || !int.TryParse(result, out var n));

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct! Press any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadLine();
            }

            if (i != 4) continue;

            Console.WriteLine($"Game over. Your final score is {score}.\nPress any key to go back to the main menu.");
            Console.ReadLine();
        }

        Helpers.AddToHistory(score, GameType.Addition);
    }

    internal static void SubtractionGame(string message)
    {
        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);
            var result = "";

            do
            {
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} - {secondNumber}");

                result = Console.ReadLine();
            } while (result == "" || !int.TryParse(result, out var n));

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer was correct! Press any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadLine();
            }

            if (i != 4) continue;

            Console.WriteLine($"Game over. Your final score is {score}.\nPress any key to go back to the main menu.");
            Console.ReadLine();
        }

        Helpers.AddToHistory(score, GameType.Subtraction);
    }

    internal static void MultiplicationGame(string message)
    {
        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            var firstNumber = random.Next(1, 9);
            var secondNumber = random.Next(1, 9);
            var result = "";

            do
            {
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} * {secondNumber}");

                result = Console.ReadLine();
            } while (result == "" || !int.TryParse(result, out var n));

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer was correct! Press any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadLine();
            }

            if (i != 4) continue;

            Console.WriteLine($"Game over. Your final score is {score}.\nPress any key to go back to the main menu.");
            Console.ReadLine();
        }

        Helpers.AddToHistory(score, GameType.Multiplication);
    }

    internal static void DivisionGame(string message)
    {
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];
            var result = "";

            do
            {
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} / {secondNumber}");

                result = Console.ReadLine();
            } while (result == "" || !int.TryParse(result, out var n));

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("Your answer was correct! Press any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
                Console.ReadLine();
            }

            if (i != 4) continue;

            Console.WriteLine($"Game over. Your final score is {score}.\nPress any key to go back to the main menu.");
            Console.ReadLine();
        }

        Helpers.AddToHistory(score, GameType.Division);
    }
}