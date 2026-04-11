namespace Constructors
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; } = Role.Guest;

        public User() 
        {
            Console.WriteLine("Hello from default ctor");
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            Role = Role.Manager;
        }

        public User(string name, int age, string email, Role role)
        {
            Name = name;
            Age = age;
            Role = role;
            Email = email;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Email: {Email}, Role {Role}");
        }
    }
}
