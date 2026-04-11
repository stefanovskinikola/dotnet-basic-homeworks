using Domain.Enums;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        public double SharesPrice { get; private set; }

        public CEO(
            int id,
            string firstName,
            string lastName,
            int age,
            double salary,
            Seniority seniority,
            Employee[] employees,
            int shares,
            double sharesPrice)
            : base(id, firstName, lastName, age, salary, seniority)
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = sharesPrice;
        }

        public void UpdateSharesPrice(double amount)
        {
            SharesPrice = amount;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double CalculateAnnualBonus()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
