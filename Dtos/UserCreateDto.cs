namespace Shopping.Dtos
{
    public class UserCreateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime AccountCreated { get; set; } = DateTime.Now;
    }
}