using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class SchedulingModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public CustomerModel Customer { get; set; }
        public int CustomerId { get; set; }
        public ServiceModel Service { get; set; }
        public int ServiceId { get; set; }
    }
}
