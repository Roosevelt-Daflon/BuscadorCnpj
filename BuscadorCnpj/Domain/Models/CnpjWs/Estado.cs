using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;
        public int IbgeId { get; set; }
    }
}
