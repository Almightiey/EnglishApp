using Domain.CourseBoundaryModel;
using Domain.LessonBoundaryModel;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public interface IApplicationDbContext
{
    DbSet<Course> Courses { get; set; }
    DbSet<Group> Groups { get; set; }

    DbSet<Lesson> Lessons { get; set; }
    DbSet<Unit> Units { get; set; }
    DbSet<Source> Sources { get; set; }
    DbSet<UnitTask> Tasks { get; set; }
    DbSet<Level> Levels { get; set; }
}
