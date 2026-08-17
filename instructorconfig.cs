using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_2_entityf_ramework
{
    public class instructorconfig: IEntityTypeConfiguration<instructor>
    {
        public void Configure(EntityTypeBuilder<instructor> builder)
        {
            builder.HasKey(i => i.Id);
            builder.HasData(new List<instructor>
            {
                new instructor { Id = 1, name = "Ahmed Ali", email = "ahmed@test.com", specialization = "Backend" },
                new instructor { Id = 2, name = "Mona Hassan", email = "mona@test.com", specialization = "Frontend" },
                new instructor { Id = 3, name = "Omar Said", email = "omar@test.com", specialization = "Database" }
            });

        }
    }
}
