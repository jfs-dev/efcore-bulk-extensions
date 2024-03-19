using efcore_bulk_extensions.Models;
using efcore_bulk_extensions.Repositories;

CustomerRepository customerRepository = new();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("BulkInsert Customer");
Console.WriteLine("-------------------");

var customersBulkInsert = new List<Customer>
{
    new() { Name = "Peter Parker", Email = "peter.parker@marvel.com" },
    new() { Name = "Ben Parker", Email = "ben.parker@marvel.com" },
    new() { Name = "Mary Jane", Email = "mary.jane@marvel.com" },
    new() { Name = "Stan Lee", Email = "stan.lee@marvel.com"}
};

customerRepository.BulkInsert(customersBulkInsert);

Console.ForegroundColor = ConsoleColor.Magenta;

var customersBulkInserted = customerRepository.GetAllCustomers();
foreach (var customer in customersBulkInserted)
    Console.WriteLine($"Id: { customer.Id }, Nome: { customer.Name }, e-mail: { customer.Email }");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("BulkUpdate Customer");
Console.WriteLine("-------------------");

var customersBulkUpdate = customerRepository.GetAllCustomers([1, 3, 4]);
foreach (var customer in customersBulkUpdate)
{
    switch (customer.Id)
    {
        case 1:
            customer.Name = "Peter Benjamin Parker";
            break;

        case 3:
            customer.Name = "Mary Jane Watson";
            break;

        case 4:
            customer.Name = "Stanley Martin Lieber";
            break;
    }
}

customerRepository.BulkUpdate(customersBulkUpdate);

Console.ForegroundColor = ConsoleColor.Magenta;

var customersBulkUpdated = customerRepository.GetAllCustomers([1, 3, 4]);
foreach (var customer in customersBulkUpdated)
    Console.WriteLine($"Id: { customer.Id }, Nome: { customer.Name }, e-mail: { customer.Email }");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("BulkDelete Customer");
Console.WriteLine("-------------------");

var customersBulkDelete = customerRepository.GetAllCustomers([2, 4]);

customerRepository.BulkDelete(customersBulkDelete);

Console.ForegroundColor = ConsoleColor.Magenta;
foreach (var customer in customersBulkDelete)
    Console.WriteLine($"Id: { customer.Id }, Nome: { customer.Name }, e-mail: { customer.Email }");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Customers");
Console.WriteLine("---------");
Console.ForegroundColor = ConsoleColor.Magenta;

var customers = customerRepository.GetAllCustomers();
foreach (var customer in customers)
    Console.WriteLine($"Id: { customer.Id }, Nome: { customer.Name }, e-mail: { customer.Email }");