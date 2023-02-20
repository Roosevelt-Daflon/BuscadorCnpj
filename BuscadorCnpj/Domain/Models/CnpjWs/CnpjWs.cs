using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class CnpjWs
    {
        public string CnpjRaiz { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public string CapitalSocial { get; set; } = string.Empty;
        public string ResponsavelFederativo { get; set; } = string.Empty;
        public string CriadoEm { get; set; } = string.Empty;
        public string AtualizadoEm { get; set; } = string.Empty;
        public Porte? Porte { get; set; }
        public NaturezaJuridica? NaturezaJuridica { get; set; }
        public QualificacaoSocietaria? QualificacaoDoResponsavel { get; set; }
        public List<Socio> Socios { get; set; } = new List<Socio>();
        public Estabelecimento? Estabelecimento { get; set; }
        public SimplesNacionalMEI? Simples { get; set; }
    }
}
