using Domain.CourseBoundaryModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class CourseModelConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
        builder.Property(x => x.SortOrder);
    }
}

public class GroupModelConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
        builder.Property(x => x.Token).HasMaxLength(256).IsRequired();
        builder.Property(x => x.SortOrder);

        builder.HasIndex(x => x.Token).IsUnique();

        builder.HasOne(g => g.Course).WithMany(c => c.Groups).HasForeignKey(g => g.CourseId);
    }
}