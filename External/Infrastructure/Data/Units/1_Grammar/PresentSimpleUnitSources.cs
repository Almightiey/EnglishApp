using Domain.LessonBoundaryModel;

namespace Infrastructure.Data.Units;

public static class PresentSimpleUnitSources
{
    #region ToBe
    public static readonly Source Source_ToBe_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = @" to be қалай аударылады және калай қолданылады?

    'Be' етістігін біз ағылшын тілінде егер сойдемімізде етістік болмаса қолданамыз:
        кім/не кім болатынын (ол медсестра);
        кім/не қандай екенін (менің мысығым қара);
        кім/не орнын айтқан кезде (әкем жұмста).

    Егер де ағылшын тілінде сіз қандай да бір затты суреттеп немесе оның не екенін айтатын болсаныз ағылшын тілінде осы етістіктер қолданылады.",
        SortOrder = 1
    };
    public static readonly Source Source_ToBe_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "Және ұмытпау керек жайт, бұл етістіктер есімдіктерге байланысты өзгеріп отырады (am/ is/ are). ",
        SortOrder = 2
    };
    public static readonly Source Source_ToBe_3 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "енді кәзір қолдануын қарастырып көрейік. ",
        SortOrder = 3
    };
    public static readonly Source Source_ToBe_4 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = @" жекеше түр
    I am a doctor. Мен дәрігермін.
    He is clever. Ол ақылды.
    She is at home. Ол үйде.
    It is an interesting book. мынау қазықты кітап.
    You are a smart guy. Сен ақылды жігітсің.",
        SortOrder = 4
    };
    public static readonly Source Source_ToBe_5 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = @" көпше түрі
    We are good singers. Біз мұғалімбіз. 
    You are wonderful listeners. сендер кереметсіңдер. 
    They are in the room. Олар бөлмеде.",
        SortOrder = 5
    };
    public static readonly Source Source_ToBe_6 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "Так же посмотрите это видео!",
        SortOrder = 6,
        Type = SourceType.Text
    };
    public static readonly Source Source_ToBe_7 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "YlqRjy_Z3GQ",
        SortOrder = 7,
        Type = SourceType.YouTubeVideoUrl
    };
    #endregion

    #region DoDoes
    public static readonly Source Source_DoDoes_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = "Present simple - бұл жай осы шақ, бұл уақыт шағы ағылшын тілінде қайталанатын іс әрекеттерді айтқан кезде қолданамыз.",
        SortOrder = 1
    };
    public static readonly Source Source_DoDoes_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"I go to work/university every day 

Женә де бұл шақты, факттерді айтқан кезде қолданамыз.

I like pizza/sushi",
        SortOrder = 2
    };
    public static readonly Source Source_DoDoes_3 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"Сөйлем құрау әдісі present simple 

    Subject + Verb
    You like ice cream

    He / She / It + Verb(s)
    He likes ice cream",
        SortOrder = 3
    };
    public static readonly Source Source_DoDoes_4 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"болымсыз сөйлемдер

    do + not - don’t
    does + not - doesn’t

    Subject + don’t/doesn’t + Verb

    I don’t like ice cream 
    She doesn’t go to school",
        SortOrder = 4
    };
    public static readonly Source Source_DoDoes_5 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"Сұраулы сқйлемдер 

    Do/ Does + Subject + Verb 

    Do you go to university?
    Yes, I do 
    No, I don’t 

    Does he go swimming? 
    Yes, he does
    No, he doesn’t",
        SortOrder = 5
    };
    #endregion
}
