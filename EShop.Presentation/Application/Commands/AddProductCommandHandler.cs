using System.Threading;
using System.Threading.Tasks;
using EShop.Presentation.Services;
using MediatR;

namespace EShop.Presentation.Application.Commands
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, bool>
    {
        private readonly IProductService _productService;

        public AddProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var productItemList = _productService.GetAllFromFile(request.File);

            return await _productService.SaveAsync(productItemList);
        }
    }
}
