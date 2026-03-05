using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Pagamentos
{
    public class Comprovante
    {
        public void Imprimir(decimal valor) =>
            Console.WriteLine($"Comprovante: compra no valor de R$ {valor:0.00}");
    }

}
