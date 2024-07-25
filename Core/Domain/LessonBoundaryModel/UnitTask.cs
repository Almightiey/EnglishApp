using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class UnitTask : Entity
{
    public long UnitId { get; set; }
    public Unit Unit { get; set; } = null!;
    public int SortOrder { get; set; }
    public string Title { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public List<UnitTaskSource>? Sources { get; set; }
}