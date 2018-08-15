using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using EShop.Domain.Models;
using EShop.Domain.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EShop.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EShopContext _context;
        private readonly ILogger _logger;

        public ProductRepository(EShopContext context, ILogger<ProductRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<bool> BulkInsertOrUpdate(IList<ProductItem> productItems)
        {
            try
            {
                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    _logger.LogInformation("Started transaction");

                    _context.BulkInsertOrUpdate(productItems);

                    transaction.Commit();

                    return await Task.FromResult(true);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(typeof(ProductRepository).GetHashCode(), ex, ex.Message);
            }

            return await Task.FromResult(false);
        }

        public async Task<IEnumerable<ProductItem>> GetAllAsync()
        {
            return await _context.ProductItems
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
