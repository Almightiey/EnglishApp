using Application.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.CourseRequest.Queries.GetAll;

public record class GetCoursesQuery : IRequest<List<CourseDto>> { }

sealed class GetCoursesQueryHandler : IRequestHandler<GetCoursesQuery, List<CourseDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCoursesQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<CourseDto>> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
    {
        return await _context.Courses
            .Include(x => x.Groups)
            .OrderBy(x => x.SortOrder)
            .ProjectTo<CourseDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
