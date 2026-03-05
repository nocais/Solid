using Solid.Domain;
using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infrastructure
{
    public class ProdutoRepositorioEmMemoria : IRepository<Produto>, IRepositoryGuid<Produto>
    {
        private readonly List<Produto> _produtos = new();

        public void Inserir(Produto entidade) => _produtos.Add(entidade);
        public IEnumerable<Produto> Listar() => _produtos;
        public Produto BuscarPorId(Guid id) => _produtos.FirstOrDefault(p => p.Id == id);
        public void Atualizar(Guid id, Produto entidade)
        {
            var idx = _produtos.FindIndex(p => p.Id == id);
            if (idx >= 0) _produtos[idx] = entidade;
        }
    }
}

