using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class Level : Entity
{
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public List<Lesson> Lessons { get; set; }
}
