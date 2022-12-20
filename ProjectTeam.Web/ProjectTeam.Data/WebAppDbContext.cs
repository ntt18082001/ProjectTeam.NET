using Microsoft.EntityFrameworkCore;
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
        public WebAppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
