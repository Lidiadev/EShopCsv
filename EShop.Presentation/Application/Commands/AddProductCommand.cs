using AutoMapper;
using EShop.Domain.ProductAggregate;
using EShop.Presentation.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace EShop.Presentation.Application.Commands
{
    public class AddProductCommand : IRequest<bool>
    {
        public IFormFile File { get; set; }
    }

    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<DataRow, ProductRecordModel>()
                 .ForMember(p => p.ItemId, c => c.MapFrom(src => src[1]))
                 .ForMember(p => p.Id, c => c.MapFrom(src => src[0]))
                 .ForMember(p => p.ColorBrand, c => c.MapFrom(src => src[2]))
                 .ForMember(p => p.Description, c => c.MapFrom(src => src[3]))
                 .ForMember(p => p.Price, c => c.MapFrom(src => src[4].ConvertToDouble()))
                 .ForMember(p => p.DiscountPrice, c => c.MapFrom(src => src[5].ConvertToDouble()))
                 .ForMember(p => p.DeliveryTime, c => c.MapFrom(src => src[6]))
                 .ForMember(p => p.Q1, c => c.MapFrom(src => src[7]))
                 .ForMember(p => p.Size, c => c.MapFrom(src => src[8].ConvertToInt()))
                 .ForMember(p => p.Color, c => c.MapFrom(src => src[9]));
        }
    }
}
