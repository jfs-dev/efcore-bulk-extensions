using efcore_bulk_extensions.Data;
using efcore_bulk_extensions.Interfaces;
using efcore_bulk_extensions.Models;

namespace efcore_bulk_extensions.Repositories;

public class CustomerRepository : ICustomer, IDisposable
{
    private readonly AppDbContext _context = new();

    public void BulkInsert(List<Customer> customers) =>
        _context.Customers.BulkInsert(customers);

    public void BulkUpdate(List<Customer> customers) =>
        _context.Customers.BulkUpdate(customers);

    public void BulkDelete(List<Customer> customers) =>
        _context.Customers.BulkDelete(customers);

    public List<Customer> GetAllCustomers(int[] ids)
    {
        if (ids.Length == 0) return GetAllCustomers();
        
        return [.. _context.Customers.Where(x => ids.Contains(x.Id))];
    }

    public List<Customer> GetAllCustomers()
    {
        return [.. _context.Customers];
    }

    public void Dispose() => _context.Dispose();
}