using Domain.LessonBoundaryModel;
using Infrastructure.Data.Units;

namespace Infrastructure.Data.UnitTasks;

public static class GrammarUnitTasks
{
    #region Present simple
    public static readonly UnitTask ToBe_1 = new()
    {
        Id = 1,
        Title = "Complete the sentences with (am/ is/ are)",
        SortOrder = 1,
        UnitId = GrammarUnits.ToBe.Id,
    };
    public static readonly UnitTask ToBe_2 = new()
    {
        Id = 2,
        Title = "Rewrite the sentences to negatives",
        SortOrder = 2,
        UnitId = GrammarUnits.ToBe.Id,
    };
    public static readonly UnitTask ToBe_3 = new()
    {
        Id = 3,
        Title = "Make questions from these sentences",
        SortOrder = 3,
        UnitId = GrammarUnits.ToBe.Id,
    };
    #endregion
}
