using System.ComponentModel.DataAnnotations;

namespace Shopping.Dtos
{
    public class UserReadDto
    {
        
        public string Name { get; set; }= string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime AccountCreated { get; set; } = DateTime.Now;
    }
}