using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;
using System.Collections.Generic;


namespace AspNetCoreWebApiCqrsMediatr.Resources.Queries
{
    public class GetTodosProdutosQuery : IRequest<IEnumerable<Produto>>
    {
    }
}
