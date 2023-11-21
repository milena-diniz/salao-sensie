using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Enable { get; set; }
    }
}