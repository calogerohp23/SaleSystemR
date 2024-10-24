namespace SaleSystemR.Persistence.Models
{
    public class OrdenDetalleArticuloCompania
    {
        public int OrdenDetalleID { get; set; }
        public int ArticuloID { get; set; }
        public string? ArticuloNombre { get; set; }
        public decimal? ArticuloValor { get; set; }
        public int OrdenID { get; set; }
        public string? OrdenNombre {  get; set; }
        public int CompaniaID { get; set; }
        public string? CompaniaNombre { get; set; }

    }
}
