using Domain.LessonBoundaryModel;
using Infrastructure.Data.Groups;

namespace Infrastructure.Data.Lessons;

public static class VocabularyLessons
{
    public static readonly Lesson Lesson_1 = new()
    {
        Id = 5,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Vocabulary.Name}_{nameof(VocabularyGroups.Family)}",
        LevelId = Levels.A1.Id,
        SortOrder = 1,
        Description = $"Family {nameof(Lesson)} - {Levels.A1.Code}"
    };
}
