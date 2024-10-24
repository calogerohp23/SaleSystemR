namespace SaleSystemR.Persistence.Models
{
    public class OrdenEmpleadoModel
    {
        public int OrdenID { get; set; }
        public string? OrdenNombre { get; set; }
        public decimal? OrdenValorTotal { get; set; }
        public string? OrdenEstado { get; set; }
        public int EmpleadoID { get; set; }
        public string? EmpleadoNombre { get; set; }
    }
}
