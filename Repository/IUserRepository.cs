using Shopping.Models;

namespace Shopping.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserAsync(Guid Id);
        Task<User> PostAsync(User user);
        void Delete(Guid Id);
    }
}