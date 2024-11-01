using InternSystemClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace InternSystemCore.Data
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options): base(options)
        {
        }

        public virtual DbSet<Intern> Interns { get; set; } = default!;
        public virtual DbSet<Project> Projects { get; set; } = default!;
        public virtual DbSet<Department> Departments { get; set; } = default!;
        public virtual DbSet<PersonalDetails> PersonalDetails { get; set; } = default!;
        public virtual DbSet<ProjectComments> ProjectComments { get; set; } = default!;
        public virtual DbSet<InternProject> InternProjects { get; set; } = default!;

    }
}
