using Domain.CourseBoundaryModel;

namespace Infrastructure.Data.Groups;

public static class SpeakingGroups
{
    public static readonly Group Family = new()
    {
        Id = 12,
        Name = "Family",
        Token = $"{Courses.Speaking.Name}_{nameof(Family)}",
        SortOrder = 1,
        CourseId = Courses.Speaking.Id,
    };
}
