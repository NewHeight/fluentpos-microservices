using BuildingBlocks.Web;
using FluentPOS.Catalog.Application.Products.Dtos;
using FluentPOS.Catalog.Application.Products.Features;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace FluentPOS.Catalog.Host.Controllers;

public class ProductsController : BaseController
{
    [HttpGet("{productId:int}")]
    [ProducesResponseType(typeof(ProductResponseDto), StatusCodes.Status200OK)]
    [SwaggerOperation(Summary = "gets product by id.", Description = "gets product by id.")]
    public async Task<IActionResult> GetAsync(int productId, CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(new GetProductByIdQuery(productId), cancellationToken);

        return Ok(result);
    }
}