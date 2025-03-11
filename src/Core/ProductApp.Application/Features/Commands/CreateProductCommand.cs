using System;
using AutoMapper;
using MediatR;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Commands
{
	public class CreateProductCommand:IRequest<ServiceResponse<Guid>>
	{
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }


        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
        {
                IProductRepository _productRep;
                IMapper mapper;

            public CreateProductCommandHandler(IProductRepository _productRep,IMapper mapper)
            {
                this._productRep = _productRep;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = mapper.Map<Domain.Entities.Product>(request);
                await _productRep.AddSync(product);

                return new ServiceResponse<Guid>(product.Id);
            }
 
        }
    }
}

