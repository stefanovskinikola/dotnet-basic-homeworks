using Enums;

Console.WriteLine("Hello, Enums!");

// ===> AI TIP: Ask AI the three main questions:  What? Why? When? !!!

// 1) What is an Enum ?
// 2) Why use Enums ?
// 3) When to use Enums ?

Console.WriteLine("\n======= Using Enums =======");

Role userRole = Role.User;

if (userRole == Role.Admin)
{
    Console.WriteLine("Full access granted.");
}
else
{
    Console.WriteLine("Limited access.");
}

Console.WriteLine("\n======= Converting Enums =======");

// Enum to string
string roleName = Role.Admin.ToString();
roleName = $"{Role.Admin}";
Console.WriteLine(roleName);
Console.WriteLine(Role.Guest);

// string to Enum 
bool isValidRole = Enum.TryParse("Manager2", out Role parsedRole);
if (isValidRole)
{
    Console.WriteLine(parsedRole);
}

// Enum to int 
int roleNumber = (int)Role.Guest;
Console.WriteLine("The numeric value of Role.Guest is " + roleNumber);

// int to Enum
Role roleFromInt = (Role)3;
Console.WriteLine(roleFromInt);


Console.WriteLine("\n======= Retrieving Enum's Values =======");

// Example: Get Enum Values 
Array values = Enum.GetValues(typeof(OrderStatus));
foreach (OrderStatus value in values)
{
    Console.WriteLine(value);
}


Console.ReadLine();