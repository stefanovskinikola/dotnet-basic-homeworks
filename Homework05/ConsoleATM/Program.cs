using ConsoleATM;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Customer> customers =
[
    new("John", "Doe", "1234-5678-9012-3456", "1111", 10000.00m),
    new("Jane", "Doe", "9876-5432-1098-7654", "2222", 20000.00m)
];

AtmService atmService = new AtmService(customers);

atmService.Run();