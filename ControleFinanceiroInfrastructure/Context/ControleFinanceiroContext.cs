using ControleFinanceiroDomain.Models;
using ControleFinanceiroInfrastructure.Configuration;
using Microsoft.EntityFrameworkCore;


namespace ControleFinanceiroInfrastructure.Context
{
    public class ControleFinanceiroContext : DbContext
    {
        public ControleFinanceiroContext(DbContextOptions<ControleFinanceiroContext> options)
            : base(options)
        {

        }

        public DbSet<Despesa> ControleDespesas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ControleDespesaConfiguration());
            modelBuilder.Entity<Despesa>().HasKey(t => t.IdDespesa);
        }
    }
}
