using AutoMapper;

namespace Application.Mappings;

internal interface IMapFrom<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}
