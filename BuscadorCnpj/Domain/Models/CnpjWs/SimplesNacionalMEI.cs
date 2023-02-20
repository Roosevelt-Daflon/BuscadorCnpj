using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorCnpj.Domain.Models.CnpjWs
{
    public class SimplesNacionalMEI
    {
        public string Simples { get; set; } = string.Empty;
        public string DataOpcaoSimples { get; set; } = string.Empty;
        public string DataExclusaoSimples { get; set; } = string.Empty;
        public string Mei { get; set; } = string.Empty;
        public string DataOpcaoMei { get; set; } = string.Empty;
        public string DataExclusaoMei { get; set; } = string.Empty;
    }
}
