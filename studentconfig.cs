using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_2_entityf_ramework
{
    public class studentconfig:IEntityTypeConfiguration<student>
    {
        public void Configure(EntityTypeBuilder<student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.fullname).HasColumnName("name");
            builder.Property(s => s.percent).HasColumnType("decimal(4,2)");
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Student_Email", "[Email] LIKE '%_@__%.__%'");
                t.HasCheckConstraint("CK_Student_Age", "[Age] >= 16");
            });
            builder.HasData(new List<student>
            {
                new student { Id = 1, fullname = "shahd", Email = "shahd@gmail.com", age = 20, percent = 85 },
                new student { Id = 2, fullname = "Sara Ali", Email = "sara.ali@gmail.com", age = 19, percent = 92 },
                new student { Id = 3, fullname = "mariam Tarek", Email = "mariam.tarek@yahoo.com", age = 22, percent = 78 },
                new student { Id = 4, fullname = "Nour Hassan", Email = "nour.hassan@outlook.com", age = 18, percent = 88 },
                new student { Id = 5, fullname = " katy Adel", Email = "katy.adel@gmail.com", age = 21, percent = 65 },
                new student { Id = 6, fullname = "shahd", Email = "shahd@gmail.com", age = 20, percent = 85 },
                new student { Id = 7, fullname = "Sara Ali", Email = "sara.ali@gmail.com", age = 19, percent = 92 },
                new student { Id = 8, fullname = "mariam Tarek", Email = "mariam.tarek@yahoo.com", age = 22, percent = 78 },
                new student { Id = 9, fullname = "Nour Hassan", Email = "nour.hassan@outlook.com", age = 18, percent = 88 },
                new student { Id = 10, fullname = "Hana Sameh", Email = "hana.sameh@yahoo.com", age = 16, percent = 82 }
            });
        }

    }
}
