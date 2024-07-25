using Domain.LessonBoundaryModel;
using Infrastructure.Data.Lessons;

namespace Infrastructure.Data.Units;

public static class FamilyUnits
{
    public static readonly Unit FamilyListening = new()
    {
        Id = 5,
        Title = "Family",
        SortOrder = 1,
        LessonId = ListeningLessons.Lesson_1.Id,
    };
    public static readonly Unit FamilySpeaking = new()
    {
        Id = 6,
        Title = "Family",
        SortOrder = 1,
        LessonId = SpeakingLessons.Lesson_1.Id,
    };
    public static readonly Unit FamilyVocabulary = new()
    {
        Id = 7,
        Title = "Family",
        SortOrder = 1,
        LessonId = VocabularyLessons.Lesson_1.Id,
    };
}
