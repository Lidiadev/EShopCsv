using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EShop.Domain.Models;
using EShop.Domain.ProductAggregate;
using EShop.Presentation.Models.Product;
using Microsoft.AspNetCore.Http;

namespace EShop.Presentation.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IFileService<ProductRecordModel> _fileService;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IFileService<ProductRecordModel> fileService, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _fileService = fileService;
        }

        public IList<ProductItem> GetAllFromFile(IFormFile file)
        {
            var productRecordList = _fileService.ReadCSVFile(file);

            return productRecordList
                        .Distinct()
                        .Select(p => _mapper.Map<ProductItem>(p))
                        .ToList();
        }

        public async Task<IEnumerable<ProductModel>> GetAllFromDbAsync()
        {
            var productItems = await _productRepository.GetAllAsync();

            return productItems.Select(a => _mapper.Map<ProductModel>(a));
        }

        public async Task<bool> SaveAsync(IList<ProductItem> productItems)
        {
            return await _productRepository.BulkInsertOrUpdate(productItems);
        }
    }
}
