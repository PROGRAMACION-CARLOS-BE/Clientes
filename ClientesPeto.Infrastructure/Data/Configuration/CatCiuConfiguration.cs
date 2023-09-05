using ClientesPeto.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Infrastructure.Data.Configuration
{
    class CatCiuConfiguration : IEntityTypeConfiguration<CatCiu>
    {
        public void Configure(EntityTypeBuilder<CatCiu> builder)
        {
            builder.HasKey(e => e.CveCiu);
                

            builder.Property(e => e.DesCiu)
                .HasColumnName("DesCiu")
                .HasMaxLength(200)
                .IsUnicode(false);
           
        }
    }
}
