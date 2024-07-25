using Domain.LessonBoundaryModel;

namespace Infrastructure.Data.Units;

public static class PresentSimpleOrPresentContinuousUnitSources
{
    #region Video
    public static readonly Source Source_PresentContinuousVideo_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PresentSimpleOrPresentContinuousVideo.Id,
        Type = SourceType.Text,
        Content = "Present Simple or Present Continuous video",
        SortOrder = 1
    };
    public static readonly Source Source_PresentContinuousVideo_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PresentSimpleOrPresentContinuousVideo.Id,
        Type = SourceType.YouTubeVideoUrl,
        Content = "rVQ1K3pgbco",
        SortOrder = 2
    };
    #endregion
}
