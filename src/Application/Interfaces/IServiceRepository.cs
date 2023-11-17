using Domain;

namespace Application.Interfaces
{
    public interface IServiceRepository
    {
        Service GetById(int id);
    }
}
