using Domain.LessonBoundaryModel;

namespace Infrastructure.Data.Units;

public static class PresentContinuousUnitSources
{
	#region Rules
	public static readonly Source Source_PresentContinuousRules_1 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousRules.Id,
		Content = "Present continuous - настоящее длительное время, оно употребляется когда говорим о действиях которые происходит сейчас, на данный момент времени.",
		SortOrder = 1
	};
	public static readonly Source Source_PresentContinuousRules_2 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousRules.Id,
		Content = "Здесь могут стоять ключевые слова такие как: now/ right now/ at the momen",
		SortOrder = 2
	};
	public static readonly Source Source_PresentContinuousRules_3 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousRules.Id,
		Content = @"Конструкция предложения

	1.	Формула: I am + глагол-ing.
		Пример: I am singing - Я пою.

	2.	Формула: He/She/It is + глагол-ing.
		Примеры: 
			He is smiling — Ол күледі.
			She is dancing — Ол билейді.
			It is shining — Ол жарқырайды.

	3.	Формула: We/You/They are + глагол-ing.
		Примеры: 
			We are listening — Мы слушаем.
			You are reading — Вы читаете.
			They are swimming — Они плавают.

	1.	Глагол заканчивается на —е 
		Правило: последняя буква отбрасывается 
		Пример: make — making (делать)

	2.	Глагол оканчивается на —ie
		Правило: -ie заменяется на -y
		Пример: lie — lying (лежать)

	3.	Односложный глагол, оканчивающийся на гласную с согласной
		Правило: последняя согласная удваивается
		Пример: get — getting (получать)",
		SortOrder = 3
	};
	public static readonly Source Source_PresentContinuousRules_4 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousRules.Id,
		Content = @"Болымсыз сөйлемдер

	1.	Формула: I am not + глагол-ing.
		Пример: I am not singing - Мен ән айтпаймын.

	2.	Формула: He/She/It is not + глагол-ing
		Примеры:
			He is not smiling - Он не улыбается. 
			She is not dancing - Она не танцует.
			It is not shining - Оно не светит.

	3.	Формула: We/You/They are not + глагол-ing.
		Примеры: 
			We are not listening - Мы не слушаем.
			You are not reading - Вы не читаете.
			They are not swimming - Они не плавают.",
		SortOrder = 4
	};
	#endregion

	#region HowToUse
	public static readonly Source Source_PresentContinuousHowToUse_1 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousHowToUse.Id,
		Content = @"Present continuous - также мы можем использовать когда описываем, 
какое то действие или же фото, так как описание происходит сейчас, 
мы должны соответсвенно использовать время «present continuous»",
		SortOrder = 1
	};
	public static readonly Source Source_PresentContinuousHowToUse_2 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousHowToUse.Id,
		Content = @"Например: 
	She is wearing a black dress.
	She is smiling in the picture",
		SortOrder = 2
	};
	public static readonly Source Source_PresentContinuousHowToUse_3 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousHowToUse.Id,
		Content = "Таким образом мы описали ее внешность, и ее действия",
		SortOrder = 3
	};
	public static readonly Source Source_PresentContinuousHowToUse_4 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousHowToUse.Id,
		Content = "Следующий случай употребление времени «present continuous» - это когда говорим о запланированных и обязательно происходящих событий в ближайшем будущем",
		SortOrder = 4
	};
	public static readonly Source Source_PresentContinuousHowToUse_5 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousHowToUse.Id,
		Content = @"Слова-маркеры: 

	This/next week (на этой/следующей неделе)
	Tonight (вечером)
	Today (сегодня)
	Tomorrow (завтра)
	This/next year (в этом/следующем году)
	This/next weekend (в эти/следующие выходные).",
		SortOrder = 5
	};
	public static readonly Source Source_PresentContinuousHowToUse_6 = new()
	{
		Id = Guid.NewGuid(),
		UnitId = GrammarUnits.PresentContinuousHowToUse.Id,
		Content = @"Например: 
	I am meeting with Daniel tomorrow. 
	Здесь в этом предложении соответсвенно показано, что встреча запланирована!",
		SortOrder = 6
	};
    #endregion

    #region Video
    public static readonly Source Source_PresentContinuousVideo_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PresentContinuousVideo.Id,
        Type = SourceType.Text,
        Content = "Present Continuous Video",
        SortOrder = 1
    };
    public static readonly Source Source_PresentContinuousVideo_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.PresentContinuousVideo.Id,
		Type = SourceType.YouTubeVideoUrl,
        Content = "CM6ZCrms5qw",
        SortOrder = 2
    };
    #endregion
}
