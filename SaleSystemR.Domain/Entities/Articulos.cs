using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SaleSystemR.Domain.Entities
{
    [Table("Articulos", Schema = "dbo")]
    public sealed class Articulos
    {
        [Key]
        public int ArticuloID { get; set; }
        public string? Nombre { get; set; }
        public decimal? Valor { get; set; }
        public int CompaniaID { get; set; }
    }
}
