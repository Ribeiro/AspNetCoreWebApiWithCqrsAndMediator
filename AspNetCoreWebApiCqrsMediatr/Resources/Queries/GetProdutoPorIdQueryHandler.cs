using AspNetCoreWebApiCqrsMediatr.Context;
using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCoreWebApiCqrsMediatr.Resources.Queries
{
    public class GetProdutoPorIdQueryHandler : IRequestHandler<GetProdutoPorIdQuery, Produto>
    {
        private readonly AppDbContext _context;

        public GetProdutoPorIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> Handle(GetProdutoPorIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Produtos.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
