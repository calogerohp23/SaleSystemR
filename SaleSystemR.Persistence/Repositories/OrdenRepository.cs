using Microsoft.Extensions.Logging;
using SaleSystemR.Domain.Entities;
using SaleSystemR.Persistence.Base;
using SaleSystemR.Persistence.Context;
using SaleSystemR.Persistence.Interfaces;

namespace SaleSystemR.Persistence.Repositories
{
    public class OrdenRepository : BaseRepository<Orden>, IOrdenRepository
    {
        private readonly SaleSystemRContext _saleSystemRContext;
        private readonly ILogger _logger;
        public OrdenRepository(SaleSystemRContext saleSystemRContext, ILogger<OrdenRepository> logger) : base(saleSystemRContext)
        {
            _saleSystemRContext = saleSystemRContext;
            _logger = logger;
        }
    }
}
