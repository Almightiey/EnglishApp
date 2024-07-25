using Application.Mappings;
using AutoMapper;
using Domain.LessonBoundaryModel;

namespace Application.Handlers.UnitRequest.Queries.GetAll;

public class UnitDto : IMapFrom<Unit>
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public int SortOrder { get; set; }
    public long LessonId { get; set; }
    public List<SourceDto>? Sources { get; set; }
    public List<UnitTaskDto>? Tasks { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Unit, UnitDto>();
    }
}

public class SourceDto : IMapFrom<Source>
{
    public SourceType Type { get; set; }
    public int SortOrder { get; set; }
    public string Content { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Source, SourceDto>();
    }
}

public class UnitTaskDto : IMapFrom<UnitTask>
{
    public long Id { get; set; }
    public long UnitId { get; set; }
    public int SortOrder { get; set; }
    public string Title { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public List<UnitTaskSourceDto>? Sources { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<UnitTask, UnitTaskDto>();
    }
}

public class UnitTaskSourceDto : IMapFrom<UnitTaskSource>
{
    public long UnitTaskId { get; set; }
    public TaskSourceType Type { get; set; }
    public int SortOrder { get; set; }
    public string? Key { get; set; }
    public string Content { get; set; } = null!;
    public string? Value { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<UnitTaskSource, UnitTaskSourceDto>();
    }
}
