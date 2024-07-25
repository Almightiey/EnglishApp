using Application.Handlers.GroupRequest.Queries.GetAll;
using Application.Mappings;
using AutoMapper;
using Domain.CourseBoundaryModel;

namespace Application.Handlers.CourseRequest.Queries.GetAll;

public class CourseDto : IMapFrom<Course>
{
    public long Id { get; set; }
    public int SortOrder { get; set; }
    public string Name { get; set; } = null!;
    public List<GroupDto> Groups { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Course, CourseDto>();
    }
}