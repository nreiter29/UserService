using Microsoft.EntityFrameworkCore;
using UserService;
using UserService.Models;

namespace ClUserService
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        UserRepo Users { get; }
        RoleRepo Roles { get; }
    }

    public class UserRepo(UserContext _context)
    {
        public User Get(string input)
        {
            var user = _context.Users.Include(u => u.Roles).FirstOrDefault(user => user.Username == input);

            if (user != null)
                return user;
            else
                return null;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
        }
    }

    public class RoleRepo(UserContext _context)
    {
        public Role Get(string input)
        {
            var role = _context.Roles.Include(r => r.Users).FirstOrDefault(role => role.Title == input);

            if (role != null)
                return role;
            else
                return null;
        }

        public void Add(Role role)
        {
            _context.Roles.Add(role);
        }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserContext _context = new UserContext();

        public UserRepo Users { get; private set; }
        public RoleRepo Roles { get; private set; }

        public UnitOfWork()
        {
            Users = new UserRepo(_context);
            Roles = new RoleRepo(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}