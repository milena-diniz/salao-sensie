using Application.Dtos;
using Application.Interfaces;
using Domain;

namespace Application.UseCases
{
    public class DoScheduleUseCase : IDoScheduleUseCase
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ISchedulingRepository _schedulingRepository;

        public DoScheduleUseCase(IServiceRepository serviceRepository, ICustomerRepository customerRepository, ISchedulingRepository schedulingRepository)
        {
            _serviceRepository = serviceRepository;
            _customerRepository = customerRepository;
            _schedulingRepository = schedulingRepository;
        }

        public Scheduling Schedule(DoScheduleDto dto)
        {
            var service = _serviceRepository.GetById(dto.ServiceId);
            if (service is null) throw new Exception("Service not found");

            var customer = _customerRepository.GetByPhone(dto.Phone);
            if (customer is null)
                customer = _customerRepository.Add(new Customer
                {
                    Name = dto.Name,
                    Phone = dto.Phone
                });

            var resultModel = new Scheduling
            {
                StartDateTime = dto.DateTime,
                EndDateTime = dto.DateTime.Add(service.Duration),
                Customer = customer,
                CustomerId = customer.Id,
                Service = service,
                ServiceId = service.Id,
            };

            return _schedulingRepository.Add(resultModel);
        }
    }
}
