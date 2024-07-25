using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class Lesson : Entity, ISortable
{
    public int SortOrder {get; set; }
    public string GroupToken { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public long LevelId { get; set; }
    public Level Level { get; set; } = null!;
    public List<Unit> Units { get; set; } = null!;
}