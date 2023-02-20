using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class Estabelecimento
    {
        public string Cnpj { get; set; } = string.Empty;
        public List<AtividadeEconomica> AtividadesSecundarias { get; set; } = new List<AtividadeEconomica>();
        public string CnpjRaiz { get; set; } = string.Empty;
        public string CnpjOrdem { get; set; } = string.Empty;
        public string CnpjDigitoVerificador { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string NomeFantasia { get; set; } = string.Empty;
        public string SituacaoCadastral { get; set; } = string.Empty;
        public DateTime DataSituacaoCadastral { get; set; }
        public DateTime DataInicioAtividade { get; set; }
        public string NomeCidadeExterior { get; set; } = string.Empty;
        public string TipoLogradouro { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Ddd1 { get; set; } = string.Empty;
        public string Telefone1 { get; set; } = string.Empty;
        public string Ddd2 { get; set; } = string.Empty;
        public string Telefone2 { get; set; } = string.Empty;
        public string DddFax { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SituacaoEspecial { get; set; } = string.Empty;
        public DateTime DataSituacaoEspecial { get; set; }
        public AtividadeEconomica? AtividadePrincipal { get; set; }
        public Pais? Pais { get; set; }
        public Estado? Estado { get; set; }
        public Cidade? Cidade { get; set; }
        public SituacaoCadastral? MotivoSituacaoCadastral { get; set; }
        public List<InscricoesEstaduais> InscricoesEstaduais { get; set; } = new List<InscricoesEstaduais>();
    }
}
