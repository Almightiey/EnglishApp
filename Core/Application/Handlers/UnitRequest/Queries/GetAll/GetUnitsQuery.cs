using Application.Handlers.LessonRequest.Queries.GetAll;
using Application.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.UnitRequest.Queries.GetAll;

public record class GetUnitsQuery(long LessonId) : IRequest<List<UnitDto>>;

sealed class GetUnitsQueryHandler : IRequestHandler<GetUnitsQuery, List<UnitDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetUnitsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<UnitDto>> Handle(GetUnitsQuery request, CancellationToken cancellationToken)
    {
        var result = await _context.Units
            .Include(x => x.Sources)
            .Include(x => x.Tasks)
            .Where(x => x.LessonId == request.LessonId)
            .OrderBy(x => x.SortOrder)
            .ProjectTo<UnitDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        return result;
    }
}
