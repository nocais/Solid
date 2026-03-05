using Projeto.Domain;
using Projeto.Infrastructure;
using Solid.Aplicacao;
using Solid.Domain;
using Solid.Infraestrutura;
using Solid.Pagamentos;

class Program
{
    static void Main(string[] args)
    {
        var carrinho = new CarrinhoDeCompras();
        carrinho.AdicionarProduto("Mouse", 79.90m, 2);
        carrinho.AdicionarProduto("Teclado", 159.90m, 1);

        IPagamento pagamento = new PagamentoPix();
        pagamento.Pagar(carrinho.ValorTotal);

        var comprovante = new Comprovante();
        comprovante.Imprimir(carrinho.ValorTotal);

        var repoProduto = new ProdutoRepositorioEmMemoria();
        var repoNota = new NotaFiscalRepositorioEmMemoria();
        var logger = new ConsoleLogger();
        var validadorProduto = new ValidadorProduto();

        var service = new CadastroService(repoProduto, repoProduto, repoNota, repoNota, logger, validadorProduto);

        service.CadastrarProduto(new Produto { Descricao = "Mouse", ValorUnitario = 79.90m });
        service.CadastrarProduto(new Produto { Descricao = "Teclado", ValorUnitario = 159.90m });
        service.CadastrarProduto(new Produto { Descricao = "", ValorUnitario = 100m }); // inválido

        service.CadastrarNota(new NotaFiscal { Numero = 1, Cliente = "Ricardo", ValorTotal = 319.70m });
        service.CadastrarNota(new NotaFiscal { Numero = 2, Cliente = "Empresa X", ValorTotal = 500m });

        service.ListarTudo();

        Console.ReadLine();
    }
}
