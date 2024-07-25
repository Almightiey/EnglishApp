using Domain.LessonBoundaryModel;

namespace Infrastructure.Data.Units;

public static class PastSimpleUnitSources
{
    #region Video
    public static readonly Source Source_PastSimpleToBeVideo_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PastSimpleToBeVideo.Id,
        Type = SourceType.Text,
        Content = "Past Simple to be (was / were).",
        SortOrder = 1
    };
    public static readonly Source Source_PastSimpleToBeVideo_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PastSimpleToBeVideo.Id,
        Type = SourceType.YouTubeVideoUrl,
        Content = "C58y_VX6iuk",
        SortOrder = 2
    };
    #endregion

    #region Video
    public static readonly Source Source_PastSimpleDidVideo_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PastSimpleDidVideo.Id,
        Type = SourceType.Text,
        Content = "Past Simple (did)",
        SortOrder = 1
    };
    public static readonly Source Source_PastSimpleDidVideo_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PastSimpleDidVideo.Id,
        Type = SourceType.YouTubeVideoUrl,
        Content = "wOLckypfQWY",
        SortOrder = 2
    };
    #endregion
}
