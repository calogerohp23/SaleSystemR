using Microsoft.EntityFrameworkCore;
using SaleSystemR.Domain.Entities;

namespace SaleSystemR.Persistence.Context
{
    public partial class SaleSystemRContext : DbContext
    {
        public SaleSystemRContext(DbContextOptions<SaleSystemRContext> options) : base(options)
        {

        }

        public DbSet<Articulos> Articulo { get; set; }
        public DbSet<Compania> Compania { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalle { get; set; }
    }
}
