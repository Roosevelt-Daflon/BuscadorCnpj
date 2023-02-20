using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class AtividadeEconomica
    {
        public string Id { get; set; } = null!;
        public string Secao { get; set; } = null!;
        public string Divisao { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public string Classe { get; set; } = null!;
        public string Subclasse { get; set; } = null!;
        public string Descricao { get; set; } = null!;
    }
}
