﻿using Microsoft.Extensions.Logging;
using SaleSystemR.Domain.Entities;
using SaleSystemR.Persistence.Base;
using SaleSystemR.Persistence.Context;
using SaleSystemR.Persistence.Interfaces;

namespace SaleSystemR.Persistence.Repositories
{
    public class ArticuloRepository : BaseRepository<Articulos>, IArticulosRepository
    {
        private readonly SaleSystemRContext _context;
        private readonly ILogger<ArticuloRepository> _logger;
        public ArticuloRepository(SaleSystemRContext saleSystemRContext, ILogger<ArticuloRepository> logger) : base(saleSystemRContext)
        {
            _context = saleSystemRContext;
            _logger = logger;
        }


    }
}