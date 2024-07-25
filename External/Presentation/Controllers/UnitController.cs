using Application.Handlers.UnitRequest.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UnitController
{
    private readonly ISender _sender;

    public UnitController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(List<UnitDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IResult> GetUnits(long lessonId)
    {
        return TypedResults.Ok(await _sender.Send(new GetUnitsQuery(lessonId)));
    }
}
