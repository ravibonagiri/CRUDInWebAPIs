using CRUDInWebAPIs.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDInWebAPIs.Data
{

    public class OrganizationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-MSQQ9TJ\\SQLEXPRESS;Database=OrgAPI;Trusted_Connection=True;");
        }

        public DbSet<Department> Departments { get; set; }
    }
}
