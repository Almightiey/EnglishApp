using Domain.LessonBoundaryModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class LessonModelConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(256).IsRequired();
        builder.Property(x => x.SortOrder);
        builder.Property(x => x.Title).HasMaxLength(1024).IsRequired(false);

        builder.HasOne(les => les.Level).WithMany(level => level.Lessons).HasForeignKey(u => u.LevelId);

        builder.HasIndex(x => new { x.GroupToken, x.SortOrder});
    }
}

public class LevelModelConfiguration : IEntityTypeConfiguration<Level>
{
    public void Configure(EntityTypeBuilder<Level> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Code).HasMaxLength(256).IsRequired();
        builder.Property(x => x.Name).HasMaxLength(256).IsRequired();

        builder.HasIndex(x => x.Code).IsUnique();
    }
}

public class UnitModelConfiguration : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(256).IsRequired();
        builder.Property(x => x.SortOrder);

        builder.OwnsMany(u => u.Sources, s =>
        {
            s.HasKey(x => x.Id);
            s.Property(x => x.Id);

            s.Property(x => x.Type).HasDefaultValue(SourceType.Text);
            s.WithOwner().HasForeignKey(s => s.UnitId);
            s.Property(x => x.UnitId);
            s.Property(x => x.Content).HasMaxLength(4096).IsRequired();
        });

        builder.HasOne(u => u.Lesson).WithMany(l => l.Units).HasForeignKey(u => u.LessonId);
    }
}

public class UnitTaskModelConfiguration : IEntityTypeConfiguration<UnitTask>
{
    public void Configure(EntityTypeBuilder<UnitTask> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(256).IsRequired();
        builder.Property(x => x.ImageUrl);
        builder.Property(x => x.SortOrder);

        builder.OwnsMany(t => t.Sources, s =>
        {
            s.HasKey(x => x.Id);
            s.Property(x => x.Id);

            s.Property(x => x.Type).IsRequired();
            s.WithOwner().HasForeignKey(s => s.UnitTaskId);
            s.Property(x => x.UnitTaskId);
            s.Property(x => x.Key);
            s.Property(x => x.Content).IsRequired();
            s.Property(x => x.Value).HasMaxLength(4096);
        });

        builder.HasOne(t => t.Unit).WithMany(u => u.Tasks).HasForeignKey(t => t.UnitId);
    }
}