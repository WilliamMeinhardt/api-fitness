using fitness.Data;
using fitness.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace fitness.Services.Users;

public class UserService : IUserService
{
    private readonly DataContext _dbContext;

    public UserService(DataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateUser(User user)
    {
        await _dbContext.Users.AddAsync(user);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<List<User>> GetUsersAsync()
    {
        return await _dbContext.Users.ToListAsync();
    }
}