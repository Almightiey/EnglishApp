using Domain.CourseBoundaryModel;

namespace Infrastructure.Data.Groups;

public static class GrammarGroups
{
    public static readonly Group PresentSimple = new()
    {
        Id = 1,
        Name = "Present simple",
        Token = $"{Courses.Grammar.Name}_{nameof(PresentSimple)}",
        SortOrder = 1,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group PresentContinuous = new()
    {
        Id = 2,
        Name = "Present continuous",
        Token = $"{Courses.Grammar.Name}_{nameof(PresentContinuous)}",
        SortOrder = 2,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group PresentSimpleOrPresentContinuous = new()
    {
        Id = 3,
        Name = "Present simple or present continuous",
        Token = $"{Courses.Grammar.Name}_{nameof(PresentSimpleOrPresentContinuous)}",
        SortOrder = 3,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group PastSimple = new ()
    {
        Id = 4,
        Name = "Past simple",
        Token = $"{Courses.Grammar.Name}_{nameof(PastSimple)}",
        SortOrder = 4,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group PresentPerfect = new ()
    {
        Id = 5,
        Name = "Present perfect",
        Token = $"{Courses.Grammar.Name}_{nameof(PresentPerfect)}",
        SortOrder = 5,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group PastSimpleOrPresentPerfect = new()
    {
        Id = 6,
        Name = "Past simple or Present perfect",
        Token = $"{Courses.Grammar.Name}_{nameof(PastSimpleOrPresentPerfect)}",
        SortOrder = 6,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group PastContinuous = new ()
    {
        Id = 7,
        Name = "Past continuous",
        Token = $"{Courses.Grammar.Name}_{nameof(PastContinuous)}",
        SortOrder = 7,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group FutureSimple = new ()
    {
        Id = 8,
        Name = "Future simple",
        Token = $"{Courses.Grammar.Name}_{nameof(FutureSimple)}",
        SortOrder = 8,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group FutureForms = new ()
    {
        Id = 9,
        Name = "Future forms",
        Token = $"{Courses.Grammar.Name}_{nameof(FutureForms)}",
        SortOrder = 9,
        CourseId = Courses.Grammar.Id,
    };
    public static readonly Group ModalVerbs = new ()
    {
        Id = 10,
        Name = "Modal verbs",
        Token = $"{Courses.Grammar.Name}_{nameof(ModalVerbs)}",
        SortOrder = 10,
        CourseId = Courses.Grammar.Id,
    };
}