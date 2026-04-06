namespace ConsoleATM;

public static class InputHelper
{
    public static string? NormalizeCardNumber(string? cardNumber) =>
        cardNumber is null ? null : new string(cardNumber.Where(char.IsDigit).ToArray());

    public static void PrintRetryMessage(string message, int attempt)
    {
        int remaining = 3 - attempt;
        if (remaining > 0)
            Console.WriteLine($"{message}. {remaining} attempt(s) remaining.");
        else
            Console.WriteLine($"{message}. No attempts remaining.");
    }

    public static string? ReadValidInput(string prompt, Func<string, bool> validate, string errorMessage)
    {
        for (int attempts = 1; attempts <= 3; attempts++)
        {
            Console.Write(prompt);
            string input = Console.ReadLine()?.Trim() ?? string.Empty;

            if (validate(input))
                return input;

            PrintRetryMessage(errorMessage, attempts);
        }

        return null;
    }
}