using EShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShop.Domain.ProductAggregate
{
    public interface IProductRepository
    {
        Task<bool> BulkInsertOrUpdate(IList<ProductItem> productItems);
        Task<IEnumerable<ProductItem>> GetAllAsync();
    }
}
