using Application.Mappings;
using AutoMapper;
using Domain.LessonBoundaryModel;

namespace Application.Handlers.LessonRequest.Queries.GetAll;

public class LessonDto : IMapFrom<Lesson>
{
    public long Id { get; set; }
    public int SortOrder { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string LevelCode { get; set; } = null!;
    public string LevelName { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Lesson, LessonDto>();
    }
}
