using ClientesPeto.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Infrastructure.Data.Configuration
{
    public class ClienteEnviadoGMConfiguration : IEntityTypeConfiguration<ClientesEnviadosGM>
    {
        public void Configure(EntityTypeBuilder<ClientesEnviadosGM> builder)
        {
            builder.HasKey(e => e.IDClienteEnviado);

                builder.Property(e => e.CveCliente)
                    .HasColumnName("CveCliente")
                    .IsUnicode(false);

            builder.Property(e => e.NombreCliente)
                    .HasColumnName("NombreCliente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

            builder.Property(e => e.FechaEnviado).HasColumnType("datetime");


        }
    }
}
