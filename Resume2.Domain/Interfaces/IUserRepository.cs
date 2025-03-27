using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume2.Domain.Models.Auth;

namespace Resume2.Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetById(int id);// find
        List<User> GetAll();// select *
        void Add(User user);// insert
        void Update(User user);// update
        void Delete(int id);// delete
        void Delete(User user);
        void Save(); // commit
    }
}
