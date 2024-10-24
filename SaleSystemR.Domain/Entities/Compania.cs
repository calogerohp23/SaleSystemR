using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SaleSystemR.Domain.Entities
{
    [Table("Compania", Schema = "dbo")]
    public sealed class Compania
    {
        [Key]
        public int CompaniaID { get; set; }
        public string? Nombre { get; set; }
        public int EmpleadoID { get; set; }
    }
}
