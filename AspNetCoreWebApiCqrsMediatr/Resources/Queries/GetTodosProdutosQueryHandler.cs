using AspNetCoreWebApiCqrsMediatr.Context;
using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCoreWebApiCqrsMediatr.Resources.Queries
{
    public class GetTodosProdutosQueryHandler : IRequestHandler<GetTodosProdutosQuery, IEnumerable<Produto>>
    {
        private readonly AppDbContext _context;
        public GetTodosProdutosQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> Handle(GetTodosProdutosQuery request, CancellationToken cancellationToken)
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}
