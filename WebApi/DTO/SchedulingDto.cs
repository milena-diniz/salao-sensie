namespace WebApi.DTO
{
    public class SchedulingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int ServiceId { get; set; }
        public DateTime DateTime { get; set; }        
    }
}