using Microsoft.EntityFrameworkCore;
using ProjectTeam.Data.Configurations;
using ProjectTeam.Data.DataSeeders;
using ProjectTeam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam.Data
{
    public class WebAppDbContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public WebAppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfig());

            // tao du lieu
            modelBuilder.Entity<AppUser>().SeedData();
        }
    }
}
