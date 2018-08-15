using AutoMapper;
using EShop.Presentation.Application.Commands;
using EShop.Presentation.Attributes;
using Microsoft.AspNetCore.Http;

namespace EShop.Presentation.Models.Product
{
    public class ImportProductModel
    {
        [FileSize]
        [FileType("csv")]
        public IFormFile File { get; set; }
    }

    public class ImportProductModelProfile : Profile
    {
        public ImportProductModelProfile()
        {
            CreateMap<ImportProductModel, AddProductCommand>();
        }
    }
}
