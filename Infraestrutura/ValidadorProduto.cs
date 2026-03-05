using Solid.Domain;
using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Infraestrutura
{
    public class ValidadorProduto : IValidador<Produto>
    {
        public bool Validar(Produto entidade, out string erro)
        {
            if (string.IsNullOrWhiteSpace(entidade.Descricao))
            {
                erro = "Descrição não pode ser vazia.";
                return false;
            }
            erro = null;
            return true;
        }
    }

}
