using EF_CORE_new_task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_new_task.Contexts
{
    internal class LoginDbContext: DbContext
    {
           public DbSet<User> Users { get; set; }
        public readonly string _connectionString = @"Server =DESKTOP-GTVND9D\SQLEXPRESS;Database = LoginManagementDB;Trusted_Connection = True;TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
