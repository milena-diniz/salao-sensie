using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class ServiceModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Enable { get; set; }
    }
}