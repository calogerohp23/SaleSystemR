using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SaleSystemR.Domain.Entities
{
    [Table("Factura", Schema = "dbo")]
    public sealed class Factura
    {
        [Key]
        public int FacturaID { get; set; }
        public int OrdenID { get; set; }
        public string? Estado { get; set; }
        public DateOnly? FechaEstimadaDeEntrega { get; set; }
    }
}
