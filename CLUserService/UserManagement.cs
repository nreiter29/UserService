using ClUserService;
using System.Security.Cryptography;
using System.Text;
using UserService.Models;

namespace UserService
{
    public class UserService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();

        public bool Register(string userName, string password, string role)
        {
            if (_unitOfWork.Users.Get(userName) != null)
                return false;

            var userGuid = Guid.NewGuid();

            var user = new User
            {
                UserId = userGuid,
                Username = userName,
                PasswordHash = ComputeHash(password, userGuid),
                Roles = new List<Role>()
            };

            var userRole = _unitOfWork.Roles.Get(role);
            if (userRole == null)
            {
                var newRole = new Role
                {
                    Title = role
                };

                _unitOfWork.Roles.Add(newRole);
                user.Roles.Add(newRole);
            }
            else
            {
                user.Roles.Add(userRole);
            }

            _unitOfWork.Users.Add(user);
            _unitOfWork.Complete();
            return true;
        }



        public bool Login(string userName, string password)
        {
            var user = _unitOfWork.Users.Get(userName);
            if (user == null)
                return false;

            var computedHash = ComputeHash(password, user.UserId);
            return user.PasswordHash == computedHash;
        }

        public bool IsInRole(string userName, string role)
        {
            var user = _unitOfWork.Users.Get(userName);
            var roleFromUser = _unitOfWork.Roles.Get(role);

            var test = user.Roles;

            return user != null && roleFromUser != null && user.Roles?.Any(r => r.RoleId == roleFromUser.RoleId) == true;
        }


        private string ComputeHash(string input, Guid salt)
        {
            using (var sha512 = SHA512.Create())
            {
                var saltedInput = input + salt;
                byte[] bytes = Encoding.UTF8.GetBytes(saltedInput);

                for (int i = 0; i < 100; i++)
                {
                    bytes = sha512.ComputeHash(bytes);
                }

                return Convert.ToBase64String(bytes);
            }
        }
    }
}