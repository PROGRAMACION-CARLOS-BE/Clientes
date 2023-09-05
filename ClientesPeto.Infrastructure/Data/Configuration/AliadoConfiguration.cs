using ClientesPeto.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Infrastructure.Data.Configuration
{
    public class AliadoConfiguration : IEntityTypeConfiguration<Aliado>
    {
        public void Configure(EntityTypeBuilder<Aliado> builder)
        {
            builder.HasKey(e => e.IdAliado);

            builder.Property(e => e.ApMaterno)
                    .HasColumnName("AP_Materno")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.ApPaterno)
                    .HasColumnName("AP_Paterno")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.ClaveEmpleado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Departamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Estado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Nss)
                    .HasColumnName("NSS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);
        }
    }
}
