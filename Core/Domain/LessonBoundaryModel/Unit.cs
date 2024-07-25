using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class Unit : Entity, ISortable
{
    public string Title { get; set; } = null!;
    public int SortOrder { get; set; }
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;
    public List<UnitTask>? Tasks { get; set; }
    public List<Source>? Sources { get; set; }
}