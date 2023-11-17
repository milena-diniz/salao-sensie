using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.VisualBasic;
using WebApi.DTO;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class SchedulingService
    {
        private readonly SchedulingRepository _schedulingRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly ServiceRepository _serviceRepository;

        public SchedulingService(SchedulingRepository schedulingRepository, CustomerRepository customerRepository, ServiceRepository serviceRepository)
        {
            _schedulingRepository = schedulingRepository;
            _customerRepository = customerRepository;
            _serviceRepository = serviceRepository;
        }

        public SchedulingModel Create(SchedulingDto request)
        {
            var service = _serviceRepository.GetById(request.ServiceId);
            if (service is null) throw new Exception("Service not found");

            var customer = _customerRepository.GetByPhone(request.Phone);
            if (customer is null)
                customer = _customerRepository.Add(new CustomerDto
                {
                    Name = request.Name,
                    Phone = request.Phone
                });
            
            var resultModel = new SchedulingModel
            {
                StartDateTime = request.DateTime,
                EndDateTime = request.DateTime.Add(service.Duration),
                Customer = customer,
                CustomerId = customer.Id,
                Service = service,
                ServiceId = service.Id,
            };

            return _schedulingRepository.Add(resultModel);
        }
    }
}