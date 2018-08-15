using AutoMapper;
using EShop.Presentation.Application.Commands;
using EShop.Presentation.Models.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShop.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index(ProductQuery query)
        {
            return View(await _mediator.Send(query));
        }

        [HttpGet]
        public IActionResult Import()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Import(ImportProductModel importModel)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<AddProductCommand>(importModel);
                var result = await _mediator.Send(command);

                if (result)
                    return RedirectToAction("Index", "Product");
            }

            return View(importModel);
        }
    }
}