using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SaleSystemR.Domain.Entities
{
    [Table("OrdenDetalle", Schema = "dbo")]
    public sealed class OrdenDetalle
    {
        [Key]
        public int OrdenDetalleID { get; set; }
        public int ArticuloID { get; set; }
        public int CompaniaID {  get; set; }
    }
}
