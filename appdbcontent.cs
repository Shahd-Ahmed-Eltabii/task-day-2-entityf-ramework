using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_2_entityf_ramework
{
    internal class appdbcontent:DbContext
    {
        public DbSet<student> Students { get; set; }
        public DbSet<course> Courses { get; set; }
        public DbSet<instructor> Instructors { get; set; }

        public DbSet<studentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var constr = configBuilder.GetSection("Connection").Value;

            optionsBuilder.UseSqlServer(constr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(studentconfig).Assembly);
            modelBuilder.Entity<studentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students).UsingEntity<studentCourse>();

            modelBuilder.Entity<instructor>().HasMany(i => i.Courses).WithOne(c => c.instructor).HasForeignKey((c) => c.instructorId);


        }
    }

}
