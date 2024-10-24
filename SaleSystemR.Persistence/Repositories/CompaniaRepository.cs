using Microsoft.Extensions.Logging;
using SaleSystemR.Domain.Entities;
using SaleSystemR.Persistence.Base;
using SaleSystemR.Persistence.Context;
using SaleSystemR.Persistence.Interfaces;

namespace SaleSystemR.Persistence.Repositories
{
    public class CompaniaRepository : BaseRepository<Compania>, ICompaniaRepository
    {
        private readonly SaleSystemRContext _saleSystemRContext;
        private readonly ILogger<CompaniaRepository> _logger;
        public CompaniaRepository(SaleSystemRContext saleSystemRContext, ILogger<CompaniaRepository> logger) : base(saleSystemRContext)
        {
            _saleSystemRContext = saleSystemRContext;
            _logger = logger;
        }
    }
}
