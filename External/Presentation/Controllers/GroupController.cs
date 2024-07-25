using MediatR;
using System.Net.Mime;
using Application.Handlers.GroupRequest.Queries.GetAll;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
//[Authorize(AuthenticationSchemes = "Bearer")]
[Route("api/[controller]")]
public class GroupController : ControllerBase
{
    private readonly ISender _sender;

    public GroupController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(List<GroupDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IResult> GetAll(long? courseId)
    {
        return TypedResults.Ok(await _sender.Send(new GetGroupsQuery(courseId)));
    }
}
