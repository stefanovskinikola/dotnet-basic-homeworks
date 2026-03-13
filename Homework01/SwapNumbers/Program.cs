Console.Write("Enter the First Number: ");
string str1 = Console.ReadLine()!;
if (!int.TryParse(str1, out int num1))
{
    Console.WriteLine("Not a valid number!");
    return;
}

Console.Write("Input the Second Number: ");
string str2 = Console.ReadLine()!;
if (!int.TryParse(str2, out int num2))
{
    Console.WriteLine("Not a valid number!");
    return;
}

int temp = num1;
num1 = num2;
num2 = temp;

Console.WriteLine($"First Number: {num1}");
Console.WriteLine($"Second Number: {num2}");