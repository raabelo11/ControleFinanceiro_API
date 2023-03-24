using System;


namespace ControleFinanceiroDomain.Models
{
    public class Despesa
    {
        public int IdDespesa { get; set; }
        public string NomeDespesa { get; set; }
        public decimal VlrDespesa { get; set; }
        public DateTime DtDespesa { get; set; }
        public DateTime DtVencimento { get; set; }
    }
}
