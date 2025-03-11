using System;
using AutoMapper;
using MediatR;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdHander : IRequestHandler<GetProductByIdQuery, GetProductByIdViewModel>
    {
        IProductRepository _rep;
        IMapper _mapper;
        public GetProductByIdHander(IProductRepository _rep, IMapper _mapper)
        {
            this._rep = _rep;
            this._mapper = _mapper;
        }
        public async Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _rep.GetByIdAsync(request.Id);

            var dto = _mapper.Map<GetProductByIdViewModel>(entity);

            return await Task.FromResult(dto);

        }
    }
}

