using Application.Mappings;
using AutoMapper;
using Domain.LessonBoundaryModel;

namespace Application.Handlers.DictionaryRequest.Queries.GetAll;

public class EnglishLevelDto : IMapFrom<Level>
{
    public long Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Level, EnglishLevelDto>();
    }
}
