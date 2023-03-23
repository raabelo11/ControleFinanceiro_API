using ControleFinanceiroDomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroInfrastructure.Configuration
{
    public class ControleDespesaConfiguration : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> eb)
        {
            eb.Property(b => b.IdDespesa).HasColumnName("ID_DESPESA").IsRequired().HasColumnType("int").ValueGeneratedOnAdd();
            eb.Property(b => b.NomeDespesa).HasColumnName("NOME_DESPESA").IsRequired().HasColumnType("varchar(30)");
            eb.Property(b => b.VlrDespesa).HasColumnName("VLR_DESPESA").IsRequired().HasColumnType("decimal(18,2)");
            eb.Property(b => b.DtDespesa).HasColumnName("DT_DESPESA").IsRequired().HasColumnType("datetime");
            eb.Property(b => b.DtVencimento).HasColumnName("DT_VENCIMENTO").IsRequired().HasColumnType("datetime");
            eb.ToTable("ControleDespesa");
            eb.HasKey(b => new { b.IdDespesa });
        }
    }
}
