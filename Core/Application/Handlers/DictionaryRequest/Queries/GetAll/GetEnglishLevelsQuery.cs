using MediatR;
using AutoMapper;
using Application.Services;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.DictionaryRequest.Queries.GetAll;

public record class GetEnglishLevelsQuery() : IRequest<List<EnglishLevelDto>>;

sealed class GetEnglishLevelsQueryHandler : IRequestHandler<GetEnglishLevelsQuery, List<EnglishLevelDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetEnglishLevelsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<EnglishLevelDto>> Handle(GetEnglishLevelsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Levels
            .ProjectTo<EnglishLevelDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
