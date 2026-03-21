int[] numbers = new int[6];
int sum = 0;
int validNumbersCount = 0;

while (validNumbersCount < numbers.Length)
{
    Console.Write($"Enter number {validNumbersCount + 1}: ");

    if (int.TryParse(Console.ReadLine(), out numbers[validNumbersCount]))
    {
        if (numbers[validNumbersCount] % 2 == 0)
        {
            sum += numbers[validNumbersCount];
        }
        validNumbersCount++;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

Console.WriteLine($"The sum of all even numbers is: {sum}");