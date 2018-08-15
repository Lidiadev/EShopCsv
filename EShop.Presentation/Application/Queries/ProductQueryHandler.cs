using EShop.Presentation.Models.Product;
using EShop.Presentation.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EShop.Presentation.Application.Queries
{
    public class ProductQueryHandler : IRequestHandler<ProductQuery, IEnumerable<ProductModel>>
    {
        private readonly IProductService _productService;

        public ProductQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IEnumerable<ProductModel>> Handle(ProductQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetAllFromDbAsync();
        }
    }
}
    