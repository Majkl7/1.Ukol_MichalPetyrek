using Microsoft.EntityFrameworkCore;
using StudentManagementApp.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace StudentManagementApp;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Enrollment> Enrollments { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Username=postgres;Password=Michalovoheslo1234;Database=postgres_courses");
    }
}
