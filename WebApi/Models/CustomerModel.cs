using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}