using AspNetCoreWebApiCqrsMediatr.Context;
using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCoreWebApiCqrsMediatr.Resources.Commands
{
    public class ProdutoCreateCommandHandler : IRequestHandler<ProdutoCreateCommand, Produto>
    {
        private readonly AppDbContext _context;
        public ProdutoCreateCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Produto> Handle(ProdutoCreateCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto();
            produto.CodigoBarras = request.CodigoBarras;
            produto.Nome = request.Nome;
            produto.Preco = request.Preco;
            produto.Taxa = request.Taxa;
            produto.Descricao = request.Descricao;

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return produto;
        }
    }
}
