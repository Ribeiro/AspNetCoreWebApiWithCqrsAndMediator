using AspNetCoreWebApiCqrsMediatr.Context;
using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCoreWebApiCqrsMediatr.Resources.Commands
{
    public class ProdutoUpdateCommandHandler : IRequestHandler<ProdutoUpdateCommand, Produto>
    {
        private readonly AppDbContext _context;
        public ProdutoUpdateCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Produto> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
        {
            var produto = _context.Produtos.Where(a => a.Id == request.Id).FirstOrDefault();
            if (null == produto)
            {
                return default;
            }
            else
            {
                produto.CodigoBarras = request.CodigoBarras;
                produto.Nome = request.Nome;
                produto.Preco = request.Preco;
                produto.Taxa = request.Taxa;
                produto.Descricao = request.Descricao;

                await _context.SaveChangesAsync();
                return produto;
            }

        }

    }
}
