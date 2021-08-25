using AspNetCoreWebApiCqrsMediatr.Models;
using MediatR;


namespace AspNetCoreWebApiCqrsMediatr.Resources.Commands
{
    public class ProdutoUpdateCommand : IRequest<Produto>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CodigoBarras { get; set; }
        public bool Ativo { get; set; } = true;
        public string Descricao { get; set; }
        public decimal Taxa { get; set; }
        public decimal Preco { get; set; }
    }
}
