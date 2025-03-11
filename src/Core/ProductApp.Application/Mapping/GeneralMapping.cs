using System;
using AutoMapper;
using ProductApp.Application.Features.Commands;
using ProductApp.Application.Features.Queries.GetProductById;

namespace ProductApp.Application.Mapping
{
	public class GeneralMapping:Profile
	{

		public GeneralMapping()
		{
            CreateMap<Domain.Entities.Product, Dto.ProductViewDto>()
                .ReverseMap();

            CreateMap<Domain.Entities.Product, CreateProductCommand>()
            .ReverseMap();

            CreateMap<Domain.Entities.Product, GetProductByIdViewModel>()
                .ReverseMap();
        }
	}
}

