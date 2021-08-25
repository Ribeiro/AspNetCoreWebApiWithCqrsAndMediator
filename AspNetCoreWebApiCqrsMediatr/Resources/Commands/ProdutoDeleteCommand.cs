using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;

namespace AspNetCoreWebApiCqrsMediatr.Resources.Commands
{
    public class ProdutoDeleteCommand : IRequest<Produto>
    {
        public int Id { get; set; }
    }
}
