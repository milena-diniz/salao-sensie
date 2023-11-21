using Application.Dtos;
using Domain;

namespace Application.UseCases
{
    public interface IDoScheduleUseCase
    {
        Scheduling Schedule(DoScheduleDto dto);
    }
}