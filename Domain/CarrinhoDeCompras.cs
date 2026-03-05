using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain
{
    public class CarrinhoDeCompras
    {
        public decimal ValorTotal { get; private set; }

        public void AdicionarProduto(string descricao, decimal valorUnitario, int quantidade)
        {
            ValorTotal += valorUnitario * quantidade;
        }
    }
}

