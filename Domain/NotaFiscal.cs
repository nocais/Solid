using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Domain
{
    public class NotaFiscal
    {
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public decimal ValorTotal { get; set; }
    }

}
