Queue<double> numberQueue = new Queue<double>();
string response;

do
{
    while (true)
    {
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            numberQueue.Enqueue(number);
            break;
        }

        Console.WriteLine("Invalid input. Please ensure you type a valid number.");
    }

    Console.Write("Do you want to input another? (Y/N): ");
    response = Console.ReadLine()?.Trim().ToUpper();
} while (response == "Y");

Console.WriteLine("Here are your numbers in the order you entered them:");

while (numberQueue.Count > 0)
{
    Console.WriteLine(numberQueue.Dequeue());
}