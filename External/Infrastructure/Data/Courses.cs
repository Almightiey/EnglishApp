using Domain.CourseBoundaryModel;

namespace Infrastructure.Data;

public static class Courses
{
    public static readonly Course Grammar = new() { Id = 1, Name = "Grammar", SortOrder = 1 };
    public static readonly Course Vocabulary = new() { Id = 2, Name = "Vocabulary", SortOrder = 2 };
    public static readonly Course Listening = new() { Id = 3, Name = "Listening", SortOrder = 3 };
    public static readonly Course Speaking = new() { Id = 4, Name = "Speaking", SortOrder = 4 };
}