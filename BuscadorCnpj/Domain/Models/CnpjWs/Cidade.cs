using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public  class Cidade
    {
        public string Nome { get; set; } = string.Empty;
        public int IbgeId { get; set; }
        public string SiafiId { get; set; } = string.Empty;
    }
}
