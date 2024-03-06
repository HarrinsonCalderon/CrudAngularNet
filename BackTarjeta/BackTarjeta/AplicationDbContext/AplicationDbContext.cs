using BackTarjeta.Models;
using Microsoft.EntityFrameworkCore;

namespace BackTarjeta.AplicationDbContext
{
    public class AplicationDbContext:DbContext
    {
        public virtual DbSet<TarjetaCredito> tarjetaCreditos { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //        => optionsBuilder.UseSqlServer("Server=TIU-2011;database=DBAPI;Trusted_Connection=true;Trust Server Certificate=true;Integrated Security=False;Persist Security Info=True;User ID=sa;Password=12345");

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

           

            base.OnModelCreating(builder);
        }

    }
}
