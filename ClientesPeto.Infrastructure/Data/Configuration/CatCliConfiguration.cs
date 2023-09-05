using ClientesPeto.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientesPeto.Infrastructure.Data.Configuration
{
    public class CatCliConfiguration : IEntityTypeConfiguration<CatCli>
    {
        public void Configure(EntityTypeBuilder<CatCli> builder)
        {

            builder.HasKey(e => e.CVECLI)
                .HasName("PK__CVECLI__0C7D20B71DE57479");

            builder.Property(e => e.NOMCLI)
                .HasColumnName("NOMCLI")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.RFCCLI)
                .HasColumnName("RFCCLI")
                .HasMaxLength(20)
                .IsUnicode(false);
            builder.Property(e => e.IDENTCLI)
                 .HasColumnName("IDENTCLI")
                 .HasMaxLength(100)
                 .IsUnicode(false);
            builder.Property(e => e.DIRCLI)
                 .HasColumnName("DIRCLI")
                 .HasMaxLength(200)
                 .IsUnicode(false);
            builder.Property(e => e.COLCLI)
                .HasColumnName("COLCLI")
                .HasMaxLength(80)
                .IsUnicode(false);
            builder.Property(e => e.CPCLI)
            .HasColumnName("CPCLI")
            .HasMaxLength(10)
            .IsUnicode(false);
            builder.Property(e => e.CIUCLI)
            .HasColumnName("CIUCLI")
            .HasMaxLength(10)
            .IsUnicode(false);

            builder.Property(e => e.CURPCLI)
                .HasColumnName("CURPCLI")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.EMAILCLI)
                .HasColumnName("EMAILCLI")
                .HasMaxLength(10)
                .IsUnicode(false);
            builder.Property(e => e.TEL1CLI)
                .HasColumnName("TEL1CLI")
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.GRUCLI)
                .HasColumnName("GRUCLI")
                .IsUnicode(false); 

            builder.Property(e => e.CVEOCU)
                .HasColumnName("CVEOCU")
                .IsUnicode(false);

            builder.Property(e => e.CVENAC)
                .HasColumnName("CVENAC")
                .IsUnicode(false);

            builder.Property(e => e.CVEEDUCIV)
                .HasColumnName("CVEOCU")
                .IsUnicode(false);

            builder.Property(e => e.CVEMED)
                .HasColumnName("CVEMED")
                .IsUnicode(false);

            builder.Property(e => e.TEL2CLI)
                .HasColumnName("TEL2CLI")
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.FECALT).HasColumnType("datetime");
            builder.Property(e => e.FecNac).HasColumnType("datetime");
            builder.Property(e => e.Sexo)
                .HasColumnName("Sexo")
                .HasMaxLength(1)
                .IsUnicode(false);
            builder.Property(e => e.ARCHIVO1)
                .IsRequired()
                .HasColumnName("ARCHIVO1")
                .HasColumnType("image")
                .HasDefaultValueSql("('')");
            builder.Property(e => e.ARCHIVO1NOM)
                .IsRequired()
                .HasColumnName("ARCHIVO1NOM")
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            //builder.Property(e => e.IMAGEN)
            //    .IsRequired()
            //    .HasColumnName("IMAGEN")
            //    .HasColumnType("image")
            //    .HasDefaultValueSql("('')");
            //builder.Property(e => e.IMAGEN2)
            //    .IsRequired()
            //    .HasColumnName("IMAGEN")
            //    .HasColumnType("image")
            //    .HasDefaultValueSql("('')");

        }
    }
}
