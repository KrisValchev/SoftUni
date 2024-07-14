using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
	public class StudentSystemContext : DbContext
	{
		public StudentSystemContext()
		{

		}
		public StudentSystemContext(DbContextOptions<StudentSystemContext> options) : base(options)
		{

		}
		public DbSet<Student> Students { get; set; } = null!;
		public DbSet<Course> Courses { get; set; } = null!;
		public DbSet<Resource> Resources { get; set; } = null!;
		public DbSet<Homework> Homeworks { get; set; } = null!;
		public DbSet<StudentCourse> StudentsCourses { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>(s =>
			{
			s.HasKey(s => s.StudentId);
			s.Property(s => s.Name)
				.IsUnicode(true);
			s.Property(s => s.PhoneNumber)
			  .IsUnicode(false);
			}
			);

			modelBuilder.Entity<Course>(c =>
			{
				c.HasKey(c => c.CourseId);
				c.Property(c => c.Name)
				.IsUnicode(true);
				c.Property(c => c.Description)
				.IsUnicode(true);
			});

			modelBuilder.Entity<Resource>(r =>
			{
				r.HasKey(r => r.ResourceType);
				r.Property(r => r.Name)
				.IsUnicode(true);
				r.Property(r => r.Url)
				.IsUnicode(false);
			});

			modelBuilder.Entity<Homework>(h =>
			{
				h.HasKey(h => h.HomeworkId);
				h.Property(h => h.Content).IsUnicode(false);
			});

			modelBuilder.Entity<StudentCourse>(sc =>
			{
				sc.HasKey(sc => new { sc.StudentId, sc.CourseId });
			});
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (optionsBuilder.IsConfigured == false)
			{
				string connectionString = "Server=KVALCHEV\\SQLEXPRESS;DataBase=StudentsSystem;Integrated Security=True;";
				optionsBuilder.UseSqlServer(connectionString);
			}
		}

	}
}
