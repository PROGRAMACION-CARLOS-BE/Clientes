using ClientesPeto.Core.Entities;
using ClientesPeto.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Infrastructure.Data
{
    public partial class EmpPetoContext : DbContext
    {
        public EmpPetoContext()
        {
        }

        public EmpPetoContext(DbContextOptions<EmpPetoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatCli> CatCli { get; set; }
        public virtual DbSet<CatCiu> CatCiu { get; set; }
        public virtual DbSet<ClientesEnviadosGM> ClientesEnviadosGM { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CatCliConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteEnviadoGMConfiguration());
            modelBuilder.ApplyConfiguration(new CatCiuConfiguration());
        }
    }
}
