using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;


namespace AspNetCoreWebApiCqrsMediatr.Resources.Queries
{
    public class GetProdutoPorIdQuery : IRequest<Produto>
    {
        public int Id { get; set; }
    }
}
