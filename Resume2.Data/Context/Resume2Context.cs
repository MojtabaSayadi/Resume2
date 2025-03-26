using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Resume2.Domain.Models.Auth;

namespace Resume2.Data.Context
{
    public class Resume2Context : DbContext

    {
        public Resume2Context(DbContextOptions<Resume2Context> options):base(options) 
        {
            
        }
        public DbSet<User> users { get; set; }
    }
}
