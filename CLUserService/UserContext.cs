using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService;

public class UserContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;User Id=sa;Password=viqsuj-danvyg-giqhE3;TrustServerCertificate=True;MultipleActiveResultSets=true");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
}
