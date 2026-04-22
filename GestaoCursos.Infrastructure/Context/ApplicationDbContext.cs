using GestaoCursos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestaoCursos.Infrastructure.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet <Enrollment> Enrollments { get; set; }
        public DbSet <Course> Courses { get; set; } 
        public DbSet <Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
