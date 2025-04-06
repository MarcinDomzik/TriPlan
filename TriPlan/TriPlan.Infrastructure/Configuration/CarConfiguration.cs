using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriPlan.Domain.Entities;

namespace TriPlan.Infrastructure.Configuration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.Property(x => x.Brand)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Model)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
