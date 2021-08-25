using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreWebApiCqrsMediatr.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [StringLength(80, MinimumLength = 4)]
        public string Nome { get; set; }
        public string CodigoBarras { get; set; }
        public bool Ativo { get; set; } = true;
        [StringLength(80, MinimumLength = 4)]
        public string Descricao { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Taxa { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
    }
}
