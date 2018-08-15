using EShop.Domain.Models;
using EShop.Presentation.Models.Product;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShop.Presentation.Services
{
    public interface IProductService
    {
        IList<ProductItem> GetAllFromFile(IFormFile file);
        Task<IEnumerable<ProductModel>> GetAllFromDbAsync();
        Task<bool> SaveAsync(IList<ProductItem> productItems);
    }
}
