using Application.Services;
using Domain.CourseBoundaryModel;
using Domain.LessonBoundaryModel;
using Infrastructure.Data;
using Infrastructure.Data.Groups;
using Infrastructure.Data.Lessons;
using Infrastructure.Data.Units;
using Infrastructure.Data.UnitTasks;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Group> Groups { get; set; }

    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Source> Sources { get; set; }
    public DbSet<UnitTask> Tasks { get; set; }
    public DbSet<Level> Levels { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("application");

        builder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly)
            .SeedEntity<Course>(typeof(Courses))
            .SeedEntity<Group>(typeof(GrammarGroups))
            .SeedEntity<Group>(typeof(ListeningGroups))
            .SeedEntity<Group>(typeof(SpeakingGroups))
            .SeedEntity<Group>(typeof(VocabularyGroups))
            .SeedEntity<Level>(typeof(Levels))
            .SeedEntity<Lesson>(typeof(GrammarLessons))
            .SeedEntity<Lesson>(typeof(ListeningLessons))
            .SeedEntity<Lesson>(typeof(SpeakingLessons))
            .SeedEntity<Lesson>(typeof(VocabularyLessons))

            .SeedEntity<Unit>(typeof(GrammarUnits))
            .SeedEntity<UnitTask>(typeof(GrammarUnitTasks))
            .SeedUnitOwnsMany(typeof(PresentSimpleUnitSources))
            .SeedUnitOwnsMany(typeof(PresentContinuousUnitSources))
            .SeedUnitOwnsMany(typeof(PresentSimpleOrPresentContinuousUnitSources))
            .SeedUnitOwnsMany(typeof(PastSimpleUnitSources))
            .SeedUnitTaskOwnsMany(typeof(PresentSimpleUnitTaskSources))

            .SeedEntity<Unit>(typeof(FamilyUnits))
            .SeedUnitOwnsMany(typeof(FamilyUnitSources))
            ;
    }
}
