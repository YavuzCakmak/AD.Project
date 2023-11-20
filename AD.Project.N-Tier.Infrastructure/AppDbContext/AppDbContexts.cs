using AD.Project.N_Tier.Infrastructure.Entity.User;
using Microsoft.EntityFrameworkCore;

namespace AD.Project.N_Tier.Infrastructure.AppDbContext
{
    public class AppDbContexts : DbContext
    {
        public AppDbContexts(DbContextOptions<AppDbContexts> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
