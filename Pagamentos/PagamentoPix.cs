using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Pagamentos
{
    public class PagamentoPix : IPagamento
    {
        public string Nome => "Pix";
        public void Pagar(decimal valor) =>
            Console.WriteLine($"Pagamento no PIX: R$ {valor:0.00}");
    }

}
