using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }= string.Empty;
        [Required(ErrorMessage = "Address is required!")]
        public string Address { get; set; } = string.Empty;
        public DateTime AccountCreated { get; set; } = DateTime.Now;
    }
}