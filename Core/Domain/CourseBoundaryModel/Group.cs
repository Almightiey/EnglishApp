using Domain.Common;

namespace Domain.CourseBoundaryModel;

public class Group : Entity, ISortable
{
    public int SortOrder { get; set; }
    public string Name { get; set; } = null!;
    public string Token { get; set; } = null!;
    public long CourseId { get; set; }
    public Course Course { get; set; } = null!;
}
