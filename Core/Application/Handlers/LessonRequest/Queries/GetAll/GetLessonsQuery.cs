using MediatR;
using AutoMapper;
using Application.Services;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.LessonRequest.Queries.GetAll;

public record class GetLessonsQuery(string GroupToken) : IRequest<List<LessonDto>>;

sealed class GetLessonsQueryHandler : IRequestHandler<GetLessonsQuery, List<LessonDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetLessonsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<LessonDto>> Handle(GetLessonsQuery request, CancellationToken cancellationToken)
    {
        var result = await _context.Lessons
            .Include(x => x.Level)
            .Where(x => x.GroupToken == request.GroupToken)
            .OrderBy(x => x.SortOrder)
            .ProjectTo<LessonDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        return result;
    }
}