
using fitness.Models.Users;

namespace fitness.Services.Users;

public interface IUserService {
    Task<List<User>> GetUsersAsync();

    Task<bool> CreateUser(User user);
}