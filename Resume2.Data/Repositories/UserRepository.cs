using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume2.Data.Context;
using Resume2.Domain.Interfaces;
using Resume2.Domain.Models.Auth;

namespace Resume2.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private  readonly Resume2Context context;
    
        public UserRepository(Resume2Context _context)
        {
            context = _context;
        }

        public void Add(User user)
        {
            context.users.Add(user);
        }

        public void Delete(int id)
        {
            context.users.Remove(GetById(id));
        }

        public void Delete(User user)
        {
            context.users.Remove(user);

        }

        public List<User> GetAll()
        {
            return context.users.ToList();
        }

        public User GetById(int id)
        {
            return context.users.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(User user)
        {
            context.users.Update(user);
        }
    }
}
