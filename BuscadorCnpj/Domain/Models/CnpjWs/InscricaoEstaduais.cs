namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class InscricoesEstaduais
    {
        public string InscricaoEstadual { get; set; } = string.Empty;
        public bool Ativo { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public Estado? Estado { get; set; }
    }
}