using MediatR;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Handlers.DictionaryRequest.Queries.GetAll;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DictionaryController : ControllerBase
{
    private readonly ISender _sender;

    public DictionaryController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("level")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(List<EnglishLevelDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IResult> GetLevels()
    {
        return TypedResults.Ok(await _sender.Send(new GetEnglishLevelsQuery()));
    }
}
