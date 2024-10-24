using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SaleSystemR.Domain.Entities
{
    [Table("Empleado", Schema = "dbo")]
    public sealed class Empleado
    {
        [Key]
        public int EmpleadoID { get; set; }
        public string? Nombre { get; set; }
        public int CompanyID { get; set; }
    }
}
