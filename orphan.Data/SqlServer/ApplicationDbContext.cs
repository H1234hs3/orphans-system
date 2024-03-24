using Microsoft.EntityFrameworkCore;
using orphan.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Data.SqlServer
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            var sqlcon = @"Server=HASSAN\SQLEXPRESS;Database=OrphanDB;Trusted_Connection=true;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(sqlcon);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        public DbSet<NewOrphan> NewOrphan { get; set; }
        public DbSet<Country>  country  { get; set; }
        public DbSet<City> city { get; set; }
        public DbSet<Directorate> directorate  { get; set; }
        public DbSet<Nationality> nationality  { get; set; }
        public DbSet<Village> village   { get; set; }




    }
}
