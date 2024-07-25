using Domain.LessonBoundaryModel;
using Infrastructure.Data.Groups;

namespace Infrastructure.Data.Lessons;

public static class ListeningLessons
{
    public static readonly Lesson Lesson_1 = new()
    {
        Id = 3,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Listening.Name}_{nameof(ListeningGroups.Family)}",
        LevelId = Levels.A1.Id,
        SortOrder = 1,
        Description = $"Family {nameof(Lesson)} - {Levels.A1.Code}"
    };
}
