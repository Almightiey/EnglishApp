using Domain.LessonBoundaryModel;

namespace Infrastructure.Data;

public static class Levels
{
    public static readonly Level A1 = new()
    {
        Id = 1,
        Name = "Beginner",
        Code = nameof(A1),
    };
    public static readonly Level A2 = new()
    {
        Id = 2,
        Name = "Elementary",
        Code = nameof(A2),
    };
    public static readonly Level B1 = new()
    {
        Id = 3,
        Name = "Intermediate",
        Code = nameof(B1),
    };
    public static readonly Level B2 = new()
    {
        Id = 4,
        Name = "Upper Intermediate",
        Code = nameof(B2),
    };
    public static readonly Level C1 = new()
    {
        Id = 5,
        Name = "Advanced",
        Code = nameof(C1),
    };
    public static readonly Level C2 = new()
    {
        Id = 6,
        Name = "Proficient",
        Code = nameof(C2),
    };
}
