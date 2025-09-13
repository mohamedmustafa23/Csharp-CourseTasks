using Microsoft.EntityFrameworkCore;
using StudentsSystem.Models;

namespace StudentsSystem.Data
{
    public class StudentSystemContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentsSystem;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode();

                entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode();

                entity.Property(e => e.Description)
                .IsUnicode()
                .IsRequired(false);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode();

                entity.Property(e => e.Url)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.Property(e => e.Content)
                .IsUnicode(false);
            });

            modelBuilder.Entity<StudentCourse>()
                        .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }


    }


    
}
