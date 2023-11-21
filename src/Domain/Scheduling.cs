using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Scheduling
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }
    }
}
