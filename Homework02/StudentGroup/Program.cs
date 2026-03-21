string[] studentsG1 = { "John", "Jane", "Sarah", "Tom", "Emma" };
string[] studentsG2 = { "David", "Emily", "Chris", "Jessica", "Michael" };

while (true)
{
    Console.Write("Enter student group: (1 / 2) ");

    if (int.TryParse(Console.ReadLine(), out int group) && (group == 1 || group == 2))
    {
        if (group == 1)
        {
            Console.WriteLine("The Students in G1 are:");
            foreach (string student in studentsG1)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("The Students in G2 are:");
            foreach (string student in studentsG2)
            {
                Console.WriteLine(student);
            }
        }
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter exactly 1 or 2.");
    }
}