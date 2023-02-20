using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class Pais
    {
        public string Id { get; set; } = null!;
        public string Iso2 { get; set; } = null!;
        public string Iso3 { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string ComexId { get; set; } = null!;
    }
}
