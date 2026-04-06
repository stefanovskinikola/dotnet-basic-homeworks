namespace ConsoleATM;

public enum WithdrawResult
{
    Success,
    InvalidAmount,
    InsufficientFunds
}

public class Customer
{
    public string FirstName { get; }
    public string LastName { get; }
    public string CardNumber { get; }
    public string FullName => $"{FirstName} {LastName}";

    private string _pin;
    private decimal _balance;

    public Customer(string firstName, string lastName, string cardNumber, string pin, decimal initialBalance = 0m)
    {
        FirstName = firstName;
        LastName = lastName;
        CardNumber = cardNumber;
        _pin = pin;
        _balance = initialBalance;
    }

    public bool ValidatePin(string pin) => _pin == pin;

    public decimal GetBalance() => _balance;

    public WithdrawResult Withdraw(decimal amount)
    {
        if (amount <= 0)
            return WithdrawResult.InvalidAmount;

        if (amount > _balance)
            return WithdrawResult.InsufficientFunds;

        _balance -= amount;
        return WithdrawResult.Success;
    }

    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
            return false;

        _balance += amount;
        return true;
    }
}