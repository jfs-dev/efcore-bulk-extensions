using efcore_bulk_extensions.Models;

namespace efcore_bulk_extensions.Interfaces;

public interface ICustomer
{
    public void BulkInsert(List<Customer> customers);
    public void BulkUpdate(List<Customer> customers);
    public void BulkDelete(List<Customer> customers);
    public List<Customer> GetAllCustomers(int[] ids);
    public List<Customer> GetAllCustomers();    
}