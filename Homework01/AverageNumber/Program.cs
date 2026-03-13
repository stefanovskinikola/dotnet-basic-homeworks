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

Console.Write("Enter the third number: ");
if (!int.TryParse(Console.ReadLine(), out int num3))
{
    Console.WriteLine("Not a valid number!");
    return;
}

Console.Write("Enter the four number: ");
if (!int.TryParse(Console.ReadLine(), out int num4))
{
    Console.WriteLine("Not a valid number!");
    return;
}

int avg = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {avg}");