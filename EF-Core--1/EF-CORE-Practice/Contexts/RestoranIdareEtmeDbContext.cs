using EF_CORE_Practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Practice.Contexts;

public class RestoranIdareEtmeDbContext:DbContext
{
    private readonly string _connectionString = @"Server =DESKTOP-N4A540V;Database =RestoranManagementDB;Trusted_Connection = True;TrustServerCertificate=True;";
    
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Waiters> Waiters { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}
