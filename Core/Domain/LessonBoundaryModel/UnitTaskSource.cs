using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class UnitTaskSource : EntityGuid, ISortable
{
    public long UnitTaskId { get; set; }
    public TaskSourceType Type { get; set; }
    public int SortOrder { get; set; }
    public string? Key { get; set; }
    public string Content { get; set; } = null!;
    public string? Value { get; set; }
}

public enum TaskSourceType
{
    MissedWord,
    NegativeForm,
    Text,
    Base64Image
}