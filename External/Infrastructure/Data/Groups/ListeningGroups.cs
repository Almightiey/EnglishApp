using Domain.CourseBoundaryModel;

namespace Infrastructure.Data.Groups;

public static class ListeningGroups
{
    public static readonly Group Family = new()
    {
        Id = 11,
        Name = "Family",
        Token = $"{Courses.Listening.Name}_{nameof(Family)}",
        SortOrder = 1,
        CourseId = Courses.Listening.Id,
    };
}
