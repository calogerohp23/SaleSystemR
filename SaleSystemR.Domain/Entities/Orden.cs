using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SaleSystemR.Domain.Entities
{
    [Table("Orden", Schema = "dbo")]
    public sealed class Orden
    {
        [Key]
        public int OrdenID { get; set; }
        public string? Nombre { get; set; }
        public int EmpleadoID { get; set; }
        public decimal? ValorTotal { get; set; }
        public string? Estado { get; set; }

    }
}
