using Domain.LessonBoundaryModel;

namespace Infrastructure.Data.Units
{
    public static class FamilyUnitSources
    {
        public static readonly Source Family_Listening_1 = new()
        {
            Id = Guid.NewGuid(),
            UnitId = FamilyUnits.FamilyListening.Id,
            Content = "My Family",
            SortOrder = 1,
            Type = SourceType.Text
        };
        public static readonly Source Family_Listening_2 = new()
        {
            Id = Guid.NewGuid(),
            UnitId = FamilyUnits.FamilyListening.Id,
            Content = "b-WOj931zSU",
            SortOrder = 2,
            Type = SourceType.YouTubeVideoUrl
        };
        public static readonly Source Family_Speaking_1 = new()
        {
            Id = Guid.NewGuid(),
            UnitId = FamilyUnits.FamilySpeaking.Id,
            Content = "My Family - Learning English Speaking",
            SortOrder = 1,
            Type = SourceType.Text
        };
        public static readonly Source Family_Speaking_2 = new()
        {
            Id = Guid.NewGuid(),
            UnitId = FamilyUnits.FamilySpeaking.Id,
            Content = "kZhCip4wCKM",
            SortOrder = 2,
            Type = SourceType.YouTubeVideoUrl
        };
        public static readonly Source Family_Vocabulary_1 = new()
        {
            Id = Guid.NewGuid(),
            UnitId = FamilyUnits.FamilyVocabulary.Id,
            Content = "My Family - English Vocabulary Lesson",
            SortOrder = 1,
            Type = SourceType.Text
        };
        public static readonly Source Family_Vocabulary_2 = new()
        {
            Id = Guid.NewGuid(),
            UnitId = FamilyUnits.FamilyVocabulary.Id,
            Content = "uVYP8U2I8NA",
            SortOrder = 2,
            Type = SourceType.YouTubeVideoUrl
        };
    }
}
