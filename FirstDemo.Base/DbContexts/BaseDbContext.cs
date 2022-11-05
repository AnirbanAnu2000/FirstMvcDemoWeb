using FirstDemo.Base.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Base.DbContexts
{
    public class BaseDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public BaseDbContext(string connectionString, string assemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = assemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString,
                    a => a.MigrationsAssembly(_assemblyName));
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Course> Courses { get; set; }
    }
}
