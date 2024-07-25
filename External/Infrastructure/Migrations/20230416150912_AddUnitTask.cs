using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUnitTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                schema: "application",
                table: "Tasks");

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("002eeff7-bbb6-4ef1-91de-e1c1c6e85f22"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("074ace9a-faea-466f-b644-9a83464b9ec8"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("153e2ddb-8d95-4938-9cdf-d337eaa93687"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("279cd357-6d09-4f67-b603-809b74d4575d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("2b3fca8d-0cc6-48b0-9dc5-84192861b4cf"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3ee897d0-bd10-4f8c-b821-8d44ec40587f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("481018ea-064b-49d6-92dd-d96139ed2f35"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5590b101-32be-485d-8bc9-a1d654c79eda"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5c0e23e9-1c85-4b66-b117-ea608d3067a2"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("62f951d5-4e69-4f59-894a-f4a32409c8e5"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("83f2a27d-91b9-44d2-99b6-c22edadea90a"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("955c5a11-1082-46cd-8491-091cf5b47720"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("9ca4ee78-e109-4f24-b0fa-1bb1648ccaf5"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("a86656ea-ebe4-4140-9ab8-83a12bd4d721"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("a97fd515-e311-43af-ace1-7f7d489e6c83"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c41847e1-c6f6-4eb9-aff8-c438ea57b37d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c8c6b55a-e9c9-4fcd-b382-bc8300b082b7"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("d5c1ea8b-4106-4763-8830-1f5feb588d6e"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("e0fc5e78-7050-440a-9343-c70d490ac622"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("f956e0e4-7a17-442a-a974-2c4c0b9d59fd"));

            migrationBuilder.DropColumn(
                name: "Text",
                schema: "application",
                table: "Tasks");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "application",
                table: "Tasks",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "application",
                table: "Tasks",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                schema: "application",
                table: "Tasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                schema: "application",
                table: "Sources",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                schema: "application",
                table: "Tasks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UnitTaskSource",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UnitTaskId = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "character varying(4096)", maxLength: 4096, nullable: false),
                    Value = table.Column<string>(type: "character varying(4096)", maxLength: 4096, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTaskSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitTaskSource_Tasks_UnitTaskId",
                        column: x => x.UnitTaskId,
                        principalSchema: "application",
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Groups",
                columns: new[] { "Id", "CourseId", "Name", "SortOrder", "Token" },
                values: new object[,]
                {
                    { 11L, 3L, "Family", 1, "Listening_Family" },
                    { 12L, 4L, "Family", 1, "Speaking_Family" },
                    { 13L, 2L, "Family", 1, "Vocabulary_Family" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Lessons",
                columns: new[] { "Id", "Description", "GroupToken", "LevelId", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 3L, "Family Lesson - A1", "Listening_Family", 1L, 1, "Lesson" },
                    { 4L, "Family Lesson - A1", "Speaking_Family", 1L, 1, "Lesson" },
                    { 5L, "Family Lesson - A1", "Vocabulary_Family", 1L, 1, "Lesson" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("04b56578-b6d6-4a64-a16e-45b316edae90"), "Здесь могут стоять ключевые слова такие как: now/ right now/ at the momen", 2, 3L },
                    { new Guid("05db3ef8-3ef0-425b-814b-e12ba941af9d"), "Конструкция предложений в present simple \r\n\r\n    Subject + Verb\r\n    You like ice cream\r\n\r\n    He / She / It + Verb(s)\r\n    He likes ice cream", 3, 2L },
                    { new Guid("22cc46e7-20c5-4b80-b73c-f61769a9e0f8"), "Например: \r\n	I am meeting with Daniel tomorrow. \r\n	Здесь в этом предложении соответсвенно показано, что встреча запланирована!", 6, 4L },
                    { new Guid("2e4647ae-6101-490f-8cd1-e8e49b830907"), " Единственное число\r\n    I am a doctor. Я являюсь доктором.\r\n    He is clever. Он является умным.\r\n    She is at home. Она находится дома.\r\n    It is an interesting book. Это есть интересная книга.\r\n    You are a smart guy. Ты являешься сообразительным парнем.", 4, 1L },
                    { new Guid("3a6b4ed8-3709-48ef-b694-c2faee88902a"), "Present continuous - также мы можем использовать когда описываем, \r\nкакое то действие или же фото, так как описание происходит сейчас, \r\nмы должны соответсвенно использовать время «present continuous»", 1, 4L },
                    { new Guid("3c042ca2-f150-488d-a9af-c1738009dcb5"), "Например: \r\n	She is wearing a black dress.\r\n	She is smiling in the picture", 2, 4L },
                    { new Guid("3fec39d3-5209-4ffd-a935-5d617a4621b0"), " Множественное число \r\n    We are good singers. Мы являемся хорошими певцами. \r\n    You are wonderful listeners. Вы являетесь отличными слушателями. \r\n    They are in the room. Они находятся в комнате.", 5, 1L },
                    { new Guid("5908ba4d-8971-4b33-826e-23e4ab41b6ca"), "I go to work/university every day \r\n\r\nТакже оно употребляется, когда мы говорим про факты в настоящем.\r\n\r\nI like pizza/sushi", 2, 2L },
                    { new Guid("659e8555-bc91-495e-95e8-6e3473f6657f"), "Present simple - это простое настоящее время, оно употребляется когда говорим о действиях которые мы делаем регулярно, каждый или часто. Одним словом это действия который не заканчивается.", 1, 2L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("66fb2e24-ce94-441f-80a9-7fc5515acc86"), "YlqRjy_Z3GQ", 7, 1, 1L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("69f1408b-191e-4654-a036-08718f9ae31f"), "Таким образом мы описали ее внешность, и ее действия", 3, 4L },
                    { new Guid("8098e799-1d4f-444e-8a6d-a3be6cbca208"), "Чтобы сделать вопросительное предложение \r\n\r\n    Do/ Does + Subject + Verb \r\n\r\n    Do you go to university?\r\n    Yes, I do \r\n    No, I don’t \r\n\r\n    Does he go swimming? \r\n    Yes, he does\r\n    No, he doesn’t", 5, 2L },
                    { new Guid("9324d995-ffb2-4cab-8b4e-1a987d56303e"), "Так же посмотрите это видео!", 6, 1L },
                    { new Guid("956769d4-bfda-445f-a34b-f2354c9232c1"), "Конструкция предложения\r\n\r\n	1.	Формула: I am + глагол-ing.\r\n		Пример: I am singing - Я пою.\r\n\r\n	2.	Формула: He/She/It is + глагол-ing.\r\n		Примеры: \r\n			He is smiling — Он улыбается.\r\n			She is dancing — Она танцует.\r\n			It is shining — Оно светит.\r\n\r\n	3.	Формула: We/You/They are + глагол-ing.\r\n		Примеры: \r\n			We are listening — Мы слушаем.\r\n			You are reading — Вы читаете.\r\n			They are swimming — Они плавают.\r\n\r\n	1.	Глагол заканчивается на —е \r\n		Правило: последняя буква отбрасывается \r\n		Пример: make — making (делать)\r\n\r\n	2.	Глагол оканчивается на —ie\r\n		Правило: -ie заменяется на -y\r\n		Пример: lie — lying (лежать)\r\n\r\n	3.	Односложный глагол, оканчивающийся на гласную с согласной\r\n		Правило: последняя согласная удваивается\r\n		Пример: get — getting (получать)", 3, 3L },
                    { new Guid("9fc028bb-7c88-4729-914b-da448bf9a2a4"), "Следующий случай употребление времени «present continuous» - это когда говорим о запланированных и обязательно происходящих событий в ближайшем будущем", 4, 4L },
                    { new Guid("b87f1c47-5fa3-434b-bc05-e37665e08fcd"), "Как переводится to be и когда используется?\r\n\r\n    'Be' мы используем в 3 случаях, когда мы хотим сказать:\r\n        Кто/что кем/чем является (она медсестра);\r\n        Кто/что каким является (мой кот серый);\r\n        Кто/что где находится (папа на работе).\r\n\r\n    То есть если мы хотим описать местоположение чего-либо, состояние чего-либо или то, чем является этот предмет/человек, то мы используем глагол to be.", 1, 1L },
                    { new Guid("c0607a9b-4840-460d-9259-96f76de69d3f"), "Present continuous - настоящее длительное время, оно употребляется когда говорим о действиях которые происходит сейчас, на данный момент времени.", 1, 3L },
                    { new Guid("c160e770-7c36-46ac-a38f-44c3434d896d"), "Слова-маркеры: \r\n\r\n	This/next week (на этой/следующей неделе)\r\n	Tonight (вечером)\r\n	Today (сегодня)\r\n	Tomorrow (завтра)\r\n	This/next year (в этом/следующем году)\r\n	This/next weekend (в эти/следующие выходные).", 5, 4L },
                    { new Guid("c520930e-a413-4a2f-87d8-39339a3ffb45"), "Давайте рассмотрим примеры употребления. ", 3, 1L },
                    { new Guid("e661631f-71f3-4fbe-87b7-2cd824395c65"), "Важно знать, как глагол to be меняется в зависимости от того, кто производит действие. Это можете быть вы, ваш друг или группа людей. В настоящем времени этот глагол имеет три формы: am, is, are. ", 2, 1L },
                    { new Guid("eee4388d-57e5-4704-9aaa-a40a1cd47caa"), "Отрицательные предложения\r\n\r\n	1.	Формула: I am not + глагол-ing.\r\n		Пример: I am not singing - Я не пою.\r\n\r\n	2.	Формула: He/She/It is not + глагол-ing\r\n		Примеры:\r\n			He is not smiling - Он не улыбается. \r\n			She is not dancing - Она не танцует.\r\n			It is not shining - Оно не светит.\r\n\r\n	3.	Формула: We/You/They are not + глагол-ing.\r\n		Примеры: \r\n			We are not listening - Мы не слушаем.\r\n			You are not reading - Вы не читаете.\r\n			They are not swimming - Они не плавают.", 4, 3L },
                    { new Guid("fcb87c5e-568e-45d8-bfc1-a7371eaf8730"), "В отрицательных предложениях\r\n\r\n    do + not - don’t\r\n    does + not - doesn’t\r\n\r\n    Subject + don’t/doesn’t + Verb\r\n\r\n    I don’t like ice cream \r\n    She doesn’t go to school", 4, 2L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Tasks",
                columns: new[] { "Id", "ImageUrl", "SortOrder", "Title", "UnitId" },
                values: new object[,]
                {
                    { 1L, null, 1, "Complete the sentences with (am/ is/ are)", 1L },
                    { 2L, null, 2, "Rewrite the sentences to negatives", 1L },
                    { 3L, null, 3, "Make questions from these sentences", 1L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "UnitTaskSource",
                columns: new[] { "Id", "Content", "Key", "SortOrder", "Type", "UnitTaskId", "Value" },
                values: new object[,]
                {
                    { new Guid("08890b74-4a0e-417f-a606-3342cd04769a"), "We are from Egypt", null, 5, 1, 2L, "We are not from Egypt" },
                    { new Guid("0e0584d5-275c-4d2a-93ca-96e9f86a8126"), "They * at work.", "*", 4, 0, 1L, "are" },
                    { new Guid("10640ec1-33d6-4f8d-b451-bf6cb080062c"), "He is Kazakh", null, 10, 1, 2L, "He is not Kazakh" },
                    { new Guid("10c2bb0c-1fcd-469f-8e31-41de53118b88"), "They are Brazilian", null, 9, 1, 2L, "They are not Brazilian" },
                    { new Guid("38344196-e30f-430f-9516-4522542b342a"), "She * late for work.", "*", 6, 0, 1L, "is" },
                    { new Guid("39732ac8-44cf-4e9d-a77a-7e9c7f5ac48f"), "I * at school.", "*", 1, 0, 1L, "am" },
                    { new Guid("3a5b8cba-e95f-4b4f-a6d0-e5ab491d796b"), "We * in the office.", "*", 3, 0, 1L, "are" },
                    { new Guid("44328dd9-f81a-4318-a558-552ac63082c9"), "I am British", null, 1, 1, 2L, "I am not British" },
                    { new Guid("4b7ca567-febd-4916-b7c5-5fb2cbca3f3b"), "He * early.", "*", 5, 0, 1L, "is" },
                    { new Guid("68df48c7-537f-4283-8e42-cb85f40feb44"), "It is from China", null, 7, 1, 2L, "It is not from China" },
                    { new Guid("6b51537c-ebee-45c6-8369-a8b3b0e0e920"), "We * in Kazakhstan ", "*", 8, 0, 1L, "are" },
                    { new Guid("72799524-bd0c-46ec-badd-5a57fa633327"), "You * beautiful.", "*", 2, 0, 1L, "are" },
                    { new Guid("784b5e0d-b852-4a0f-8415-008ffb7a631e"), "She is in America", null, 6, 1, 2L, "She is not in America" },
                    { new Guid("7caddc31-49eb-4caa-83ce-bc3466d34ca7"), "He is from Turkey", null, 4, 1, 2L, "He is not from Turkey" },
                    { new Guid("7cec4f8c-47df-4d05-b9c2-863e24a426f9"), "You are Russian", null, 2, 1, 2L, "You are not Russian" },
                    { new Guid("8ec15ed8-c520-4bd8-a0bd-e7033d5b2bb0"), "You are French", null, 8, 1, 2L, "You are not French" },
                    { new Guid("942b66e9-893e-4efe-9629-5f4fd13c9481"), "You * Kazakh.", "*", 7, 0, 1L, "are" },
                    { new Guid("ab2a43e7-fa47-4956-90db-8b68fdc39933"), "My name * Yernur.", "*", 9, 0, 1L, "is" },
                    { new Guid("c7887c71-eb34-4340-96ad-adf9b532ca16"), "It * my school. ", "*", 10, 0, 1L, "is" },
                    { new Guid("e4944504-eb23-463d-9594-404ec64e3e83"), "They are in the office", null, 3, 1, 2L, "They are not in the office" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Units",
                columns: new[] { "Id", "LessonId", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 5L, 3L, 1, "Family" },
                    { 6L, 4L, 1, "Family" },
                    { 7L, 5L, 1, "Family" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("0718f39b-125b-4bbe-96d2-362ac1a9f272"), "b-WOj931zSU", 2, 1, 5L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[] { new Guid("357da888-2f29-4e4a-bb31-aec88bd0fac1"), "My Family - English Vocabulary Lesson", 1, 7L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("5a5b0abe-f106-494c-a279-e0249578e74d"), "kZhCip4wCKM", 2, 1, 6L });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("88c0ea7c-32ff-40ed-839e-0f7e3b16ae3f"), "My Family", 1, 5L },
                    { new Guid("f723b9c3-5eac-4aa8-8458-f2b6fe27a2b0"), "My Family - Learning English Speaking", 1, 6L }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "Type", "UnitId" },
                values: new object[] { new Guid("f915ddb7-e335-441d-ad60-f5ad649197cc"), "uVYP8U2I8NA", 2, 1, 7L });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UnitId",
                schema: "application",
                table: "Tasks",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitTaskSource_UnitTaskId",
                schema: "application",
                table: "UnitTaskSource",
                column: "UnitTaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitTaskSource",
                schema: "application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                schema: "application",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UnitId",
                schema: "application",
                table: "Tasks");

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("04b56578-b6d6-4a64-a16e-45b316edae90"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("05db3ef8-3ef0-425b-814b-e12ba941af9d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("0718f39b-125b-4bbe-96d2-362ac1a9f272"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("22cc46e7-20c5-4b80-b73c-f61769a9e0f8"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("2e4647ae-6101-490f-8cd1-e8e49b830907"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("357da888-2f29-4e4a-bb31-aec88bd0fac1"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3a6b4ed8-3709-48ef-b694-c2faee88902a"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3c042ca2-f150-488d-a9af-c1738009dcb5"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3fec39d3-5209-4ffd-a935-5d617a4621b0"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5908ba4d-8971-4b33-826e-23e4ab41b6ca"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5a5b0abe-f106-494c-a279-e0249578e74d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("659e8555-bc91-495e-95e8-6e3473f6657f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("66fb2e24-ce94-441f-80a9-7fc5515acc86"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("69f1408b-191e-4654-a036-08718f9ae31f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("8098e799-1d4f-444e-8a6d-a3be6cbca208"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("88c0ea7c-32ff-40ed-839e-0f7e3b16ae3f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("9324d995-ffb2-4cab-8b4e-1a987d56303e"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("956769d4-bfda-445f-a34b-f2354c9232c1"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("9fc028bb-7c88-4729-914b-da448bf9a2a4"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("b87f1c47-5fa3-434b-bc05-e37665e08fcd"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c0607a9b-4840-460d-9259-96f76de69d3f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c160e770-7c36-46ac-a38f-44c3434d896d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c520930e-a413-4a2f-87d8-39339a3ffb45"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("e661631f-71f3-4fbe-87b7-2cd824395c65"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("eee4388d-57e5-4704-9aaa-a40a1cd47caa"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("f723b9c3-5eac-4aa8-8458-f2b6fe27a2b0"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("f915ddb7-e335-441d-ad60-f5ad649197cc"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("fcb87c5e-568e-45d8-bfc1-a7371eaf8730"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Units",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "SortOrder",
                schema: "application",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Type",
                schema: "application",
                table: "Sources");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "application",
                table: "Tasks",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "application",
                table: "Tasks",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                schema: "application",
                table: "Tasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                schema: "application",
                table: "Tasks",
                column: "UnitId");

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("002eeff7-bbb6-4ef1-91de-e1c1c6e85f22"), "Например: \r\n	She is wearing a black dress.\r\n	She is smiling in the picture", 2, 4L },
                    { new Guid("074ace9a-faea-466f-b644-9a83464b9ec8"), "Present continuous - также мы можем использовать когда описываем, \r\nкакое то действие или же фото, так как описание происходит сейчас, \r\nмы должны соответсвенно использовать время «present continuous»", 1, 4L },
                    { new Guid("153e2ddb-8d95-4938-9cdf-d337eaa93687"), "Как переводится to be и когда используется?\r\n\r\n    'Be' мы используем в 3 случаях, когда мы хотим сказать:\r\n        Кто/что кем/чем является (она медсестра);\r\n        Кто/что каким является (мой кот серый);\r\n        Кто/что где находится (папа на работе).\r\n\r\n    То есть если мы хотим описать местоположение чего-либо, состояние чего-либо или то, чем является этот предмет/человек, то мы используем глагол to be.", 1, 1L },
                    { new Guid("279cd357-6d09-4f67-b603-809b74d4575d"), "Здесь могут стоять ключевые слова такие как: now/ right now/ at the momen", 2, 3L },
                    { new Guid("2b3fca8d-0cc6-48b0-9dc5-84192861b4cf"), " Единственное число\r\n    I am a doctor. Я являюсь доктором.\r\n    He is clever. Он является умным.\r\n    She is at home. Она находится дома.\r\n    It is an interesting book. Это есть интересная книга.\r\n    You are a smart guy. Ты являешься сообразительным парнем.", 4, 1L },
                    { new Guid("3ee897d0-bd10-4f8c-b821-8d44ec40587f"), "Давайте рассмотрим примеры употребления. ", 3, 1L },
                    { new Guid("481018ea-064b-49d6-92dd-d96139ed2f35"), "I go to work/university every day \r\n\r\nТакже оно употребляется, когда мы говорим про факты в настоящем.\r\n\r\nI like pizza/sushi", 2, 2L },
                    { new Guid("5590b101-32be-485d-8bc9-a1d654c79eda"), "Следующий случай употребление времени «present continuous» - это когда говорим о запланированных и обязательно происходящих событий в ближайшем будущем", 4, 4L },
                    { new Guid("5c0e23e9-1c85-4b66-b117-ea608d3067a2"), "Конструкция предложений в present simple \r\n\r\n    Subject + Verb\r\n    You like ice cream\r\n\r\n    He / She / It + Verb(s)\r\n    He likes ice cream", 3, 2L },
                    { new Guid("62f951d5-4e69-4f59-894a-f4a32409c8e5"), "Например: \r\n	I am meeting with Daniel tomorrow. \r\n	Здесь в этом предложении соответсвенно показано, что встреча запланирована!", 6, 4L },
                    { new Guid("83f2a27d-91b9-44d2-99b6-c22edadea90a"), "Present simple - это простое настоящее время, оно употребляется когда говорим о действиях которые мы делаем регулярно, каждый или часто. Одним словом это действия который не заканчивается.", 1, 2L },
                    { new Guid("955c5a11-1082-46cd-8491-091cf5b47720"), "Чтобы сделать вопросительное предложение \r\n\r\n    Do/ Does + Subject + Verb \r\n\r\n    Do you go to university?\r\n    Yes, I do \r\n    No, I don’t \r\n\r\n    Does he go swimming? \r\n    Yes, he does\r\n    No, he doesn’t", 5, 2L },
                    { new Guid("9ca4ee78-e109-4f24-b0fa-1bb1648ccaf5"), "Отрицательные предложения\r\n\r\n	1.	Формула: I am not + глагол-ing.\r\n		Пример: I am not singing - Я не пою.\r\n\r\n	2.	Формула: He/She/It is not + глагол-ing\r\n		Примеры:\r\n			He is not smiling - Он не улыбается. \r\n			She is not dancing - Она не танцует.\r\n			It is not shining - Оно не светит.\r\n\r\n	3.	Формула: We/You/They are not + глагол-ing.\r\n		Примеры: \r\n			We are not listening - Мы не слушаем.\r\n			You are not reading - Вы не читаете.\r\n			They are not swimming - Они не плавают.", 4, 3L },
                    { new Guid("a86656ea-ebe4-4140-9ab8-83a12bd4d721"), "Present continuous - настоящее длительное время, оно употребляется когда говорим о действиях которые происходит сейчас, на данный момент времени.", 1, 3L },
                    { new Guid("a97fd515-e311-43af-ace1-7f7d489e6c83"), "Слова-маркеры: \r\n\r\n	This/next week (на этой/следующей неделе)\r\n	Tonight (вечером)\r\n	Today (сегодня)\r\n	Tomorrow (завтра)\r\n	This/next year (в этом/следующем году)\r\n	This/next weekend (в эти/следующие выходные).", 5, 4L },
                    { new Guid("c41847e1-c6f6-4eb9-aff8-c438ea57b37d"), "В отрицательных предложениях\r\n\r\n    do + not - don’t\r\n    does + not - doesn’t\r\n\r\n    Subject + don’t/doesn’t + Verb\r\n\r\n    I don’t like ice cream \r\n    She doesn’t go to school", 4, 2L },
                    { new Guid("c8c6b55a-e9c9-4fcd-b382-bc8300b082b7"), "Конструкция предложения\r\n\r\n	1.	Формула: I am + глагол-ing.\r\n		Пример: I am singing - Я пою.\r\n\r\n	2.	Формула: He/She/It is + глагол-ing.\r\n		Примеры: \r\n			He is smiling — Он улыбается.\r\n			She is dancing — Она танцует.\r\n			It is shining — Оно светит.\r\n\r\n	3.	Формула: We/You/They are + глагол-ing.\r\n		Примеры: \r\n			We are listening — Мы слушаем.\r\n			You are reading — Вы читаете.\r\n			They are swimming — Они плавают.\r\n\r\n	1.	Глагол заканчивается на —е \r\n		Правило: последняя буква отбрасывается \r\n		Пример: make — making (делать)\r\n\r\n	2.	Глагол оканчивается на —ie\r\n		Правило: -ie заменяется на -y\r\n		Пример: lie — lying (лежать)\r\n\r\n	3.	Односложный глагол, оканчивающийся на гласную с согласной\r\n		Правило: последняя согласная удваивается\r\n		Пример: get — getting (получать)", 3, 3L },
                    { new Guid("d5c1ea8b-4106-4763-8830-1f5feb588d6e"), "Таким образом мы описали ее внешность, и ее действия", 3, 4L },
                    { new Guid("e0fc5e78-7050-440a-9343-c70d490ac622"), " Множественное число \r\n    We are good singers. Мы являемся хорошими певцами. \r\n    You are wonderful listeners. Вы являетесь отличными слушателями. \r\n    They are in the room. Они находятся в комнате.", 5, 1L },
                    { new Guid("f956e0e4-7a17-442a-a974-2c4c0b9d59fd"), "Важно знать, как глагол to be меняется в зависимости от того, кто производит действие. Это можете быть вы, ваш друг или группа людей. В настоящем времени этот глагол имеет три формы: am, is, are. ", 2, 1L }
                });
        }
    }
}
