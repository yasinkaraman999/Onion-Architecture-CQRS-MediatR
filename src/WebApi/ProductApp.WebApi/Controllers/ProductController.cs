using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Features.Commands;
using ProductApp.Application.Features.Queries.GetAllProduct;
using ProductApp.Application.Features.Queries.GetProductById;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator mediatr;

    public ProductController(IMediator mediatr)
    {
        this.mediatr = mediatr;
    }


    [HttpGet]
    public async Task<IActionResult>  Get()
    {
        var query = new GetAllProductQuery();

        return Ok(await mediatr.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateProductCommand command)
    {
        return Ok(mediatr.Send(command));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var query = new GetProductByIdQuery() { Id = id };
        return Ok(mediatr.Send(query));
    }

}

