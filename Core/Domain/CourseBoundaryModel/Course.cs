using Domain.Common;

namespace Domain.CourseBoundaryModel;

public class Course : Entity, ISortable
{
    public int SortOrder { get; set; }
    public string Name { get; set; } = null!;
    public List<Group> Groups { get; set; }
}
