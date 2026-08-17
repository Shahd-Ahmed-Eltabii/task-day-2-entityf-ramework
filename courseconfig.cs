using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_2_entityf_ramework
{
    public class courseconfig : IEntityTypeConfiguration<course>
    {
        public void Configure(EntityTypeBuilder<course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.description)
                .HasColumnType("VARCHAR")
                .HasMaxLength(150);

            builder.HasData(new List<course>
            {
                new course { Id = 1, name = "C# Fundamentals", description = "Learn the basics of C# programming language including variables, loops and OOP concepts.", durationInHours = 30, instructorId = 1 },
                new course { Id = 2, name = "ASP.NET Core", description = "Build modern web applications and APIs using ASP.NET Core framework.", durationInHours = 40, instructorId = 2 },
                new course { Id = 3, name = "Entity Framework Core", description = "Master Code First approach, migrations, relationships and querying with EF Core.", durationInHours = 25, instructorId = 1 },
                new course { Id = 4, name = "SQL Server Basics", description = "Understand database design, T-SQL queries, joins and stored procedures.", durationInHours = 20, instructorId = 3 },
                new course { Id = 5, name = "Web Development", description = "Introduction to HTML, CSS and JavaScript for building interactive websites.", durationInHours = 35, instructorId = 2 }
            });
        }
    }
}
