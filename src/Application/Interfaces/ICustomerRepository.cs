using Domain;

namespace Application.Interfaces
{
    public interface ICustomerRepository
    {
        Customer? GetByPhone(string phone);
        Customer Add(Customer entity);
    }
}
