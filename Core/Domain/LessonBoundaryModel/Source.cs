using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class Source : EntityGuid, ISortable
{
    public SourceType Type { get; set; }
    public long UnitId { get; set; }
    public int SortOrder { get; set; }
    public string Content { get; set; } = null!;
}

public enum SourceType
{
    Text,
    YouTubeVideoUrl,
    Json,
    Audio,
    Photo
}