Console.WriteLine("Enter your birth date. (Use your computer's date format, e.g., 01.01.2000 or 01/01/2000)");

while (true)
{
    string input = Console.ReadLine()!;

    if (input.Length < 8)
    {
        Console.WriteLine("Please enter a full date including the year (e.g., 01.01.2000 or 01/01/2000).");
        continue;
    }

    if (DateOnly.TryParse(input, out DateOnly birthDate))
    {
        int age = AgeCalculator(birthDate);

        if (age == -1)
        {
            Console.WriteLine("The birth date cannot be in the future. Please enter a valid date.");
        }
        else
        {
            Console.WriteLine($"You are {age} years old");
            break;
        }
    }
    else
    {
        Console.WriteLine("Invalid date. Please ensure it matches your computer's date format. (e.g., 01.01.2000 or 01/01/2000)");
    }
}

static int AgeCalculator(DateOnly birthDate)
{
    DateOnly today = DateOnly.FromDateTime(DateTime.Now);

    if (today < birthDate)
    {
        return -1;
    }

    int age = today.Year - birthDate.Year;

    if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
    {
        age--;
    }

    return age;
}