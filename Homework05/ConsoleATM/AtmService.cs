namespace ConsoleATM;

public class AtmService
{
    private readonly List<Customer> _customers;

    public AtmService(List<Customer> customers)
    {
        _customers = customers;
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Console ATM");

        while (true)
        {
            Console.WriteLine("\n1. Login");
            Console.WriteLine("2. Register a new card");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine()?.Trim())
            {
                case "1":
                    var customer = Login();
                    if (customer is not null)
                        AtmMenu(customer);
                    break;

                case "2":
                    RegisterCard();
                    break;

                case "3":
                    Console.WriteLine("\nThank you for using Console ATM. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private Customer? Login()
    {
        Console.Write("\nEnter card number: ");
        string? cardNumber = Console.ReadLine()?.Trim();

        string? normalizedInput = InputHelper.NormalizeCardNumber(cardNumber);
        var customer = _customers.FirstOrDefault(customer => InputHelper.NormalizeCardNumber(customer.CardNumber) == normalizedInput);

        if (customer is null)
        {
            Console.WriteLine("Card not found.");
            return null;
        }

        string? pin = InputHelper.ReadValidInput(
            "Enter PIN: ",
            input => customer.ValidatePin(input),
            "Incorrect PIN");

        if (pin is null)
            return null;

        Console.WriteLine($"\nHello, {customer.FullName}! You have been logged in successfully.");
        return customer;
    }

    private void RegisterCard()
    {
        Console.WriteLine("\nRegister New Card");

        string? firstName = InputHelper.ReadValidInput(
            "Enter first name: ",
            input => !string.IsNullOrWhiteSpace(input),
            "First name cannot be empty");

        if (firstName is null)
            return;

        string? lastName = InputHelper.ReadValidInput(
            "Enter last name: ",
            input => !string.IsNullOrWhiteSpace(input),
            "Last name cannot be empty");

        if (lastName is null)
            return;

        string? pin = InputHelper.ReadValidInput(
            "Enter a 4-digit PIN: ",
            input => input.Length == 4 && input.All(char.IsDigit),
            "PIN must be exactly 4 digits");

        if (pin is null)
            return;

        string? depositInput = InputHelper.ReadValidInput(
            "Enter initial deposit amount: ",
            input => decimal.TryParse(input, out decimal deposit) && deposit >= 0,
            "Invalid deposit amount. Please enter a valid amount");

        if (depositInput is null)
            return;

        decimal deposit = decimal.Parse(depositInput);

        string cardNumber = GenerateCardNumber();
        var newCustomer = new Customer(firstName, lastName, cardNumber, pin, deposit);
        _customers.Add(newCustomer);

        Console.WriteLine($"\nRegistration successful!");
        Console.WriteLine($"Your card number is: {cardNumber}");
        Console.WriteLine($"Welcome, {newCustomer.FullName}!");
    }

    private string GenerateCardNumber()
    {
        var random = new Random();
        string card;

        do
        {
            var digits = Enumerable.Range(0, 16).Select(_ => random.Next(0, 10));
            card = string.Join("", digits.Select((digit, index) => (index > 0 && index % 4 == 0 ? "-" : "") + digit));
        }
        while (_customers.Any(c => c.CardNumber == card));

        return card;
    }

    private void AtmMenu(Customer customer)
    {
        bool continueSession = true;

        while (continueSession)
        {
            Console.WriteLine("\nATM Menu");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Withdraw cash");
            Console.WriteLine("3. Deposit cash");
            Console.WriteLine("4. Log out");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine()?.Trim())
            {
                case "1": CheckBalance(customer); break;
                case "2": WithdrawCash(customer); break;
                case "3": DepositCash(customer); break;
                case "4":
                    Console.WriteLine("You have been logged out.");
                    continueSession = false;
                    continue;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
            }

            continueSession = AskForAnotherAction();
        }
    }

    private void CheckBalance(Customer customer)
    {
        Console.WriteLine($"\nYour current balance is: {customer.GetBalance():C}");
    }

    private void WithdrawCash(Customer customer)
    {
        for (int attempts = 1; attempts <= 3; attempts++)
        {
            Console.Write("\nEnter amount to withdraw: ");

            if (!decimal.TryParse(Console.ReadLine()?.Trim(), out decimal amount))
            {
                InputHelper.PrintRetryMessage("Invalid input. Please enter numbers only", attempts);
                continue;
            }

            var result = customer.Withdraw(amount);

            switch (result)
            {
                case WithdrawResult.Success:
                    Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {customer.GetBalance():C}");
                    return;

                case WithdrawResult.InvalidAmount:
                    InputHelper.PrintRetryMessage("Withdrawal failed. The amount must be greater than zero", attempts);
                    continue;

                case WithdrawResult.InsufficientFunds:
                    InputHelper.PrintRetryMessage($"Insufficient funds. Your current balance is {customer.GetBalance():C}", attempts);
                    continue;
            }
        }
    }

    private void DepositCash(Customer customer)
    {
        string? input = InputHelper.ReadValidInput(
            "\nEnter amount to deposit: ",
            input => decimal.TryParse(input, out decimal deposit) && deposit > 0,
            "Invalid amount. Please enter a number greater than zero");

        if (input is null)
            return;

        decimal amount = decimal.Parse(input);
        customer.Deposit(amount);
        Console.WriteLine($"Successfully deposited {amount:C}. New balance: {customer.GetBalance():C}");
    }

    private bool AskForAnotherAction()
    {
        Console.Write("\nWould you like to perform another action? (y/n): ");
        return Console.ReadLine()?.Trim().Equals("y", StringComparison.OrdinalIgnoreCase) == true;
    }
}