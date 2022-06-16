using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppEntityFrameworkTest.Configurations;

namespace WinFormsAppEntityFrameworkTest
{
    public  class ApplicationDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Ultra Database;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserEntitytypeConfiguration().Configure(modelBuilder.Entity<UserModel>());
            new BranchEntityTypeConfiguration().Configure(modelBuilder.Entity<BranchModel>());
        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<BranchModel> Branches { get; set; }

    }
}
