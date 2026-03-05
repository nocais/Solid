using Solid.Domain;
using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Aplicacao
{
    public class CadastroService
    {
        private readonly IRepository<Produto> _repoProduto;
        private readonly IRepositoryGuid<Produto> _repoProdutoGuid;
        private readonly IRepository<NotaFiscal> _repoNota;
        private readonly IRepositoryInt<NotaFiscal> _repoNotaInt;
        private readonly ILogger _logger;
        private readonly IValidador<Produto> _validadorProduto;

        public CadastroService(
            IRepository<Produto> repoProduto,
            IRepositoryGuid<Produto> repoProdutoGuid,
            IRepository<NotaFiscal> repoNota,
            IRepositoryInt<NotaFiscal> repoNotaInt,
            ILogger logger,
            IValidador<Produto> validadorProduto)
        {
            _repoProduto = repoProduto;
            _repoProdutoGuid = repoProdutoGuid;
            _repoNota = repoNota;
            _repoNotaInt = repoNotaInt;
            _logger = logger;
            _validadorProduto = validadorProduto;
        }

        public void CadastrarProduto(Produto produto)
        {
            if (_validadorProduto.Validar(produto, out var erro))
            {
                _repoProduto.Inserir(produto);
                _logger.Log($"Produto cadastrado: {produto.Descricao}");
            }
            else
            {
                _logger.Log($"Falha ao cadastrar produto: {erro}");
            }
        }

        public void CadastrarNota(NotaFiscal nota)
        {
            _repoNota.Inserir(nota);
            _logger.Log($"Nota cadastrada: {nota.Numero} - Cliente {nota.Cliente}");
        }

        public void ListarTudo()
        {
            Console.WriteLine("\nProdutos:");
            foreach (var p in _repoProduto.Listar())
                Console.WriteLine($"{p.Id} - {p.Descricao} - R$ {p.ValorUnitario}");

            Console.WriteLine("\nNotas:");
            foreach (var n in _repoNota.Listar())
                Console.WriteLine($"{n.Numero} - {n.Cliente} - R$ {n.ValorTotal}");
        }
    }

}
