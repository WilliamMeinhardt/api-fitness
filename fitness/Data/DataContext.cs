using fitness.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace fitness.Data;


    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users {get;set;}
    }