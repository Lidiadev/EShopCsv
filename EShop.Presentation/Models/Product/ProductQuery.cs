using MediatR;
using System.Collections.Generic;

namespace EShop.Presentation.Models.Product
{
    public class ProductQuery : IRequest<IEnumerable<ProductModel>>
    {
    }
}
