using Application.Mappings;
using AutoMapper;
using Domain.CourseBoundaryModel;

namespace Application.Handlers.GroupRequest.Queries.GetAll;

public class GroupDto : IMapFrom<Group>
{
    public int SortOrder { get; set; }
    public string Name { get; set; } = null!;
    public string Token { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Group, GroupDto>();
    }
}