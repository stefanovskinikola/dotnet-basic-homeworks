using Domain.Enums;
using Domain.Models;

Console.WriteLine("Hello, Inheritance!");

Developer developer = new Developer(1, "Bob", "Bobsky", 28, 5000, Seniority.Senior, "C#");
string developerDetails = developer.GetDetails();
Console.WriteLine(developerDetails);
Console.WriteLine(developer.CalculateAnnualBonus());

//Console.WriteLine(developer.Salary); // Cannot access *protected* property outside the child class
Console.WriteLine(developer.GetSalary());


Manager manager = new Manager(1, "John", "Johnsky", 34, 1000, Seniority.Junior, "IT");
Console.WriteLine(manager);

string managerDetails = manager.GetDetails();
Console.WriteLine(managerDetails);
Console.WriteLine(manager.CalculateAnnualBonus());


Console.ReadLine();