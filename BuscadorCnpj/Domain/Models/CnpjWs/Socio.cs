using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class Socio
    {
        public string CpfCnpjSocio { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string DataEntrada { get; set; } = string.Empty;
        public string CpfRepresentanteLegal { get; set; } = string.Empty;
        public string NomeRepresentante { get; set; } = string.Empty;
        public string FaixaEtaria { get; set; } = string.Empty;
        public DateTime AtualizadoEm { get; set; }
        public string PaisId { get; set; } = string.Empty;
        public QualificacaoSocietaria? QualificacaoSocio { get; set; }
        public QualificacaoSocietaria? QualificacaoRepresentante { get; set; }
    }
}
