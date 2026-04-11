using Constructors;
using Domain.Enums;
using Domain.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Hello, Constructors!");

Console.WriteLine("\n======= Default Constructor =======");

User john = new User();
john.Name = "John Doe";
john.PrintInfo();

Console.WriteLine("\n======= Parameterized Constructors =======");

User jane = new User("Jane Doe", 30);
jane.PrintInfo();

User bob = new User("Bob Bobsky", 34, "bob@bobsky.com", Role.Admin);
bob.PrintInfo();

Console.WriteLine("\n======= Homework =======\n");

Developer dev1 = new Developer(1, "Bob", "Bobsky", 28, 5000, Seniority.Senior, "C#");
Developer dev2 = new Developer(2, "Sara", "Smith", 26, 4500, Seniority.Mid, "Java");

Manager mgr1 = new Manager(3, "John", "Johnsky", 34, 7000, Seniority.Senior, "IT");
Manager mgr2 = new Manager(4, "Lisa", "Brown", 40, 7500, Seniority.Lead, "Finance");

Contractor contractor = new Contractor(5, "Tom", "Taylor", 30, 3000, Seniority.Junior, 160, 25, mgr1);

Employee[] allEmployees = { dev1, dev2, mgr1, mgr2, contractor };

CEO ceo = new CEO(6, "John", "Doe", 45, 100000, Seniority.Lead, allEmployees, 500, 100);

ceo.UpdateSharesPrice(150);

Console.WriteLine(ceo.GetDetails());

Console.WriteLine("Employees:");
ceo.PrintEmployees();

Console.WriteLine($"CEO Annual Bonus: {ceo.CalculateAnnualBonus()}");