bool raceAgain = true;
while (raceAgain)
{
    List<Car> availableCars = new List<Car>
    {
        new Car { Model = "Hyundai", Speed = 180 },
        new Car { Model = "Mazda", Speed = 190 },
        new Car { Model = "Ferrari", Speed = 320 },
        new Car { Model = "Porsche", Speed = 300 }
    };

    List<Driver> availableDrivers = new List<Driver>
    {
        new Driver { Name = "Bob", Skill = 3 },
        new Driver { Name = "Greg", Skill = 4 },
        new Driver { Name = "Jill", Skill = 5 },
        new Driver { Name = "Anne", Skill = 4 }
    };

    Console.Clear();
    Console.WriteLine("Start the race!");

    //Car 1
    Car car1 = SelectCar(availableCars, "number 1");
    availableCars.Remove(car1);

    //Driver 1
    Driver driver1 = SelectDriver(availableDrivers);
    car1.Driver = driver1;
    availableDrivers.Remove(driver1);

    //Car 2
    Car car2 = SelectCar(availableCars, "number 2");

    //Driver 2
    Driver driver2 = SelectDriver(availableDrivers);
    car2.Driver = driver2;

    RaceCars(car1, car2);

    while (true)
    {
        Console.Write("\nDo you want to race again? (y/n): ");
        string? response = Console.ReadLine()?.Trim().ToLower();

        if (response == "y")
        {
            raceAgain = true;
            break;
        }
        else if (response == "n")
        {
            raceAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
        }
    }
}

// Methods
static void RaceCars(Car car1, Car car2)
{
    int score1 = car1.CalculateScore(car1.Driver!);
    int score2 = car2.CalculateScore(car2.Driver!);

    if (score1 > score2)
    {
        Console.WriteLine($"\nCar number 1 won! The {car1.Model} took the victory with a Score of {score1} points, driven by {car1.Driver!.Name} at a top speed of {car1.Speed}km/h.");
    }
    else if (score2 > score1)
    {
        Console.WriteLine($"\nCar number 2 won! The {car2.Model} took the victory with a Score of {score2} points, driven by {car2.Driver!.Name} at a top speed of {car2.Speed}km/h.");
    }
    else
    {
        Console.WriteLine($"It's a tie! Both the {car1.Model} and the {car2.Model} achieved a Score of {score1}.");
    }
}

static int GetValidInput(int maxOption)
{
    while (true)
    {
        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= maxOption)
        {
            return choice;
        }
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

static Car SelectCar(List<Car> cars, string car)
{
    Console.WriteLine($"\nChoose a car {car}:");
    for (int i = 0; i < cars.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {cars[i].Model}");
    }

    int choice = GetValidInput(cars.Count);
    return cars[choice - 1];
}

static Driver SelectDriver(List<Driver> drivers)
{
    Console.WriteLine("\nChoose Driver:");
    for (int i = 0; i < drivers.Count; i++)
    {
        Console.WriteLine($"  {i + 1}. {drivers[i].Name}");
    }

    int choice = GetValidInput(drivers.Count);
    return drivers[choice - 1];
}

// Classes
public class Driver
{
    public string? Name { get; set; }
    public int Skill { get; set; }
}

public class Car
{
    public string? Model { get; set; }
    public int Speed { get; set; }
    public Driver? Driver { get; set; }

    // ORIGINAL REQUIREMENT:
    // Make a method of the Car class called : CalculateSpeed() that takes a driver object
    // and calculates the skill multiplied by the speed of the car and return it as a result.

    // ADJUSTMENT:
    // I am using CalculateScore instead of CalculateSpeed. This is because the result of Speed * Skill
    // is an abstract performance metric, preventing unrealistic output like a car traveling at 1,500km/h.
    public int CalculateScore(Driver driver)
    {
        return driver.Skill * Speed;
    }
}