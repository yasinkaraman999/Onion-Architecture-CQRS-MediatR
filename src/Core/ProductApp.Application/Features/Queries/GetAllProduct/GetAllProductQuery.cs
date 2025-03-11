using System;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using System.Linq;
namespace ProductApp.Application.Features.Queries.GetAllProduct
{
	public class GetAllProductQuery:IRequest<List<ProductViewDto>>
	{
       
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductViewDto>>
        {
            private readonly IProductRepository _productrep;
            public GetAllProductQueryHandler(IProductRepository _productrep)
            {
                this._productrep = _productrep;
            }

            public async Task<List<ProductViewDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await _productrep.GetAllAsync();

                return products.Select(x => new ProductViewDto()
                {
                     Id=x.Id,
                    Name = x.Name,
                    Quantity = x.Quantity,
                    Value = x.Value,

                }).ToList();
            }
        }
    }
}

