using Domain.LessonBoundaryModel;
using Infrastructure.Data.Groups;

namespace Infrastructure.Data.Lessons;

public static class GrammarLessons
{
    public static readonly Lesson Lesson_1 = new()
    {
        Id = 1,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Grammar.Name}_{nameof(GrammarGroups.PresentSimple)}",
        LevelId = Levels.A1.Id,
        SortOrder = 1,
        Description = $"Present Simple {nameof(Lesson)} - {Levels.A1.Code}"
    };
    public static readonly Lesson Lesson_2 = new()
    {
        Id = 2,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Grammar.Name}_{nameof(GrammarGroups.PresentContinuous)}",
        LevelId = Levels.A1.Id,
        SortOrder = 2,
        Description = $"Present Continuous {nameof(Lesson)} - {Levels.A1.Code}"
    };
    public static readonly Lesson Lesson_3 = new()
    {
        Id = 6,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Grammar.Name}_{nameof(GrammarGroups.PresentSimpleOrPresentContinuous)}",
        LevelId = Levels.A1.Id,
        SortOrder = 3,
        Description = $"Present Simple or Present Continuous {nameof(Lesson)} - {Levels.A1.Code}"
    };
    public static readonly Lesson Lesson_4 = new()
    {
        Id = 7,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Grammar.Name}_{nameof(GrammarGroups.PastSimple)}",
        LevelId = Levels.A1.Id,
        SortOrder = 4,
        Description = $"Past Simple {nameof(Lesson)} - {Levels.A1.Code}"
    };
}
