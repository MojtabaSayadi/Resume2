﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Resume2.Domain.Models.Auth;
using Resume2.Domain.Models.Web;

namespace Resume2.Data.Context
{
    public class Resume2Context : DbContext

    {
        public Resume2Context(DbContextOptions<Resume2Context> options):base(options) 
        {
            
        }
        public DbSet<User> users { get; set; }
        public DbSet<WebMainInfo> webMainInfo { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        //    {
        //        relationship.DeleteBehavior = DeleteBehavior.Restrict;
        //    }
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
