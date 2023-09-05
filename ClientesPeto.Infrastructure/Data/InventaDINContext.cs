using ClientesPeto.Core;
using ClientesPeto.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Data
{
    public partial class InventaDINContext : DbContext
    {
        public InventaDINContext()
        {
        }

        public InventaDINContext(DbContextOptions<InventaDINContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aliado> Aliado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AliadoConfiguration());
        }
    }
}
