using Microsoft.Extensions.Logging;
using SaleSystemR.Domain.Entities;
using SaleSystemR.Persistence.Base;
using SaleSystemR.Persistence.Context;
using SaleSystemR.Persistence.Interfaces;

namespace SaleSystemR.Persistence.Repositories
{
    public class FacturaRepository : BaseRepository<Factura>, IFacturaRepository
    {
        private readonly SaleSystemRContext _saleSytemContext;
        private readonly ILogger<FacturaRepository> _logger;

        public FacturaRepository(SaleSystemRContext saleSystemRContext, ILogger<FacturaRepository> logger) : base(saleSystemRContext)
        {
            _saleSytemContext = saleSystemRContext;
            _logger = logger;
        }
    }
}
