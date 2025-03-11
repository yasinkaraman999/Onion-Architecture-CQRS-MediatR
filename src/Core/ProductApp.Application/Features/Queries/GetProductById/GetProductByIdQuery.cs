using System;
using MediatR;

namespace ProductApp.Application.Features.Queries.GetProductById
{
	public class GetProductByIdQuery:IRequest<GetProductByIdViewModel>
	{

		public Guid Id { get; set; }

	}
}

