using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService;

public class UserContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=3APEC_UserContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
}