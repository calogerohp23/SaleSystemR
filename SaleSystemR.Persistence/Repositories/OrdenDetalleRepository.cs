using Microsoft.Extensions.Logging;
using SaleSystemR.Domain.Entities;
using SaleSystemR.Persistence.Base;
using SaleSystemR.Persistence.Context;
using SaleSystemR.Persistence.Interfaces;

namespace SaleSystemR.Persistence.Repositories
{
    public class OrdenDetalleRepository:BaseRepository<OrdenDetalle>, IOrdenDetalleRepository
    {
        private readonly SaleSystemRContext _saleSystemRContext;
        private readonly ILogger<OrdenDetalleRepository> _logger;

        public OrdenDetalleRepository(SaleSystemRContext saleSystemRContext, ILogger<OrdenDetalleRepository> logger) : base(saleSystemRContext)
        {
            _saleSystemRContext = saleSystemRContext;
            _logger = logger;
        }
    }
}
