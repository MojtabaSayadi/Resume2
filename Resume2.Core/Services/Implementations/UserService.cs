using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Core.Services.Interfaces;
using Resume2.Domain.Interfaces;
using Resume2.Domain.Models.Auth;

namespace Resume2.Core.Services.Implementations
{
    public class UserService : IUserService
    {
        private IUserRepository userRpository;
        public UserService(IUserRepository _userRepository)
        {
            userRpository = _userRepository;
        }
        public void AddUser(User user)
        {
            userRpository.Add(user);
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUsers(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(int Id)
        {
            throw new NotImplementedException();
        }

        public void SaveUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
