using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class RegimesTributarios
    {
        public string Ano { get; set; } = string.Empty;
        public string RegimeTributario { get; set; } = string.Empty;
        public string FormaDeTributacao { get; set; } = string.Empty;
    }
}
