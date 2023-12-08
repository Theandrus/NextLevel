using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<ProjectCast> ProjectCasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=cutsubs;user=root;password=uTnw0PIh65_!;";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}