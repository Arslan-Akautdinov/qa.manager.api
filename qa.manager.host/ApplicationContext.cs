using Microsoft.EntityFrameworkCore;
using qa.manager.models;

namespace qa.manager.host
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Scope> Scopes { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<ProjectStand> ProjectStands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}