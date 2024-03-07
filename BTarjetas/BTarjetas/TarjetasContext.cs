using BTarjetas.Models;
using Microsoft.EntityFrameworkCore;

namespace BTarjetas
{
    public class TarjetasContext : DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }

        public TarjetasContext(DbContextOptions<TarjetasContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TarjetaCredito>(tarjetaCredito =>
            {
                tarjetaCredito.ToTable("TarjetaCredito");
                tarjetaCredito.HasKey(p => p.IdTarjetaCredito);
                tarjetaCredito.Property(p => p.Titular).IsRequired().HasMaxLength(10);
                tarjetaCredito.Property(p => p.NumeroTarjeta).IsRequired();
                tarjetaCredito.Property(p => p.FechaExpiracion).IsRequired();
                tarjetaCredito.Property(p => p.Cvv).IsRequired();

            });
        }

    }
}
