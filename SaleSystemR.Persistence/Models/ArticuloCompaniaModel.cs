namespace SaleSystemR.Persistence.Models
{
    public class ArticuloCompaniaModel
    {
        public int ArticuloID { get; set; }
        public string? ArticuloNombre { get; set; }
        public decimal? Valor { get; set; }
        public int CompaniaID { get; set; }
        public string? CompaniaNombre { get; set; }

    }
}
