using MediatR;
using System.Net.Mime;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Handlers.LessonRequest.Queries.GetAll;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
//[Authorize(AuthenticationSchemes = "Bearer")]
public class LessonController : ControllerBase
{
    private readonly ISender _sender;

    public LessonController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(List<LessonDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IResult> GetAllByToken(string groupToken)
    {
        return TypedResults.Ok(await _sender.Send(new GetLessonsQuery(groupToken)));
    }
}