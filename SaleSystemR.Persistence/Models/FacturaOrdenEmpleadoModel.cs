namespace SaleSystemR.Persistence.Models
{
    public class FacturaOrdenEmpleadoModel
    {
        public int FacturaID { get; set; }
        public string? FacturaEstado { get; set; }
        public DateOnly? FacturaFechaEstimadaDeEntrega { get; set; }
        public string? OrdenID { get; set; }
        public string? OrdenNombre { get; set; }
        public string? OrdenEstado { get; set; }
        public int EmpleadoID { get; set; }
        public string? EmpleadoNombre { get; set; }

    }
}
