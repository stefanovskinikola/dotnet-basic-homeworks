Console.Write("Enter the First number: ");
if (!int.TryParse(Console.ReadLine(), out int num1))
{
    Console.WriteLine("Not a valid number!");
    return;
}

Console.Write("Enter the Second number: ");
if (!int.TryParse(Console.ReadLine(), out int num2))
{
    Console.WriteLine("Not a valid number!");
    return;
}

Console.Write("Enter the Operation: ");
string operation = Console.ReadLine()!;

switch (operation)
{
    case "+":
        Console.WriteLine($"The result is: {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"The result is: {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"The result is: {num1 * num2}");
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        else
        {
            Console.WriteLine($"The result is: {num1 / num2}");
        }
        break;
    default:
        Console.WriteLine("Invalid Operation!");
        break;
}
