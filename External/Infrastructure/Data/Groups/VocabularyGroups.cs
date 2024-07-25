using Domain.CourseBoundaryModel;

namespace Infrastructure.Data.Groups;

public static class VocabularyGroups
{
    public static readonly Group Family = new()
    {
        Id = 13,
        Name = "Family",
        Token = $"{Courses.Vocabulary.Name}_{nameof(Family)}",
        SortOrder = 1,
        CourseId = Courses.Vocabulary.Id,
    };
}
