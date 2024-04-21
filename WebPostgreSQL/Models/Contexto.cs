using Microsoft.EntityFrameworkCore;

namespace WebPostgreSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Violator> Violators { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<AnnualTax> AnnualTaxes { get; set; }
        public DbSet<Violation> Violations { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Payment>()
            .HasOne(p => p.Violation)
            .WithOne(v => v.Payment)
            .HasForeignKey<Violation>(v => v.PaymentId);
        }


    }
}
