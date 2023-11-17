using Domain;

namespace Application.Interfaces
{
    public interface ISchedulingRepository
    {
        Scheduling Add(Scheduling entity);
    }
}
