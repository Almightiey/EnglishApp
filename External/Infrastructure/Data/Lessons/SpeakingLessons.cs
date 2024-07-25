using Domain.LessonBoundaryModel;
using Infrastructure.Data.Groups;

namespace Infrastructure.Data.Lessons;

public static class SpeakingLessons
{
    public static readonly Lesson Lesson_1 = new()
    {
        Id = 4,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Speaking.Name}_{nameof(SpeakingGroups.Family)}",
        LevelId = Levels.A1.Id,
        SortOrder = 1,
        Description = $"Family {nameof(Lesson)} - {Levels.A1.Code}"
    };
}
