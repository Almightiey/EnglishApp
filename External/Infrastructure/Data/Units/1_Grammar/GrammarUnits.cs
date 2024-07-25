using Domain.LessonBoundaryModel;
using Infrastructure.Data.Lessons;

namespace Infrastructure.Data.Units;

public static class GrammarUnits
{
    #region Present simple
    public static readonly Unit ToBe = new()
    {
        Id = 1,
        Title = "Present simple “to be”",
        SortOrder = 1,
        LessonId = GrammarLessons.Lesson_1.Id,
    };
    public static readonly Unit DoDoes = new()
    {
        Id = 2,
        Title = "Present simple “do/does”",
        SortOrder = 2,
        LessonId = GrammarLessons.Lesson_1.Id,
    };
    #endregion

    #region Present Continuous
    public static readonly Unit PresentContinuousRules = new()
    {
        Id = 3,
        Title = "Present Continuous. Rules",
        SortOrder = 1,
        LessonId = GrammarLessons.Lesson_2.Id,
    };
    public static readonly Unit PresentContinuousHowToUse = new()
    {
        Id = 4,
        Title = "Present Continuous. How to Use It",
        SortOrder = 2,
        LessonId = GrammarLessons.Lesson_2.Id,
    };
    public static readonly Unit PresentContinuousVideo = new()
    {
        Id = 8,
        Title = "Present Continuous. Video",
        SortOrder = 3,
        LessonId = GrammarLessons.Lesson_2.Id,
    };
    #endregion

    #region Present Simple Or Present Continuous
    public static readonly Unit PresentSimpleOrPresentContinuousVideo = new()
    {
        Id = 9,
        Title = "Present Continuous. Video",
        SortOrder = 1,
        LessonId = GrammarLessons.Lesson_3.Id,
    };
    #endregion

    #region Past Simple
    public static readonly Unit PastSimpleToBeVideo = new()
    {
        Id = 10,
        Title = "Past Simple to be (was / were). Video",
        SortOrder = 1,
        LessonId = GrammarLessons.Lesson_4.Id,
    };
    public static readonly Unit PastSimpleDidVideo = new()
    {
        Id = 11,
        Title = "Past Simple (did). Video",
        SortOrder = 2,
        LessonId = GrammarLessons.Lesson_4.Id,
    };
    #endregion
}
