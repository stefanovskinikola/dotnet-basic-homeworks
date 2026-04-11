using Domain.Enums;

namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(
            int id,
            string firstName,
            string lastName,
            int age,
            double salary,
            Seniority seniority,
            double workHours,
            int payPerHour,
            Manager responsible)
            : base(id, firstName, lastName, age, salary, seniority)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double CalculateAnnualBonus()
        {
            return WorkHours * PayPerHour;
        }

        public string GetCurrentDepartment()
        {
            return Responsible.Department;
        }
    }
}
