using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "application");

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Token = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Courses_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "application",
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    GroupToken = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    LevelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Levels_LevelId",
                        column: x => x.LevelId,
                        principalSchema: "application",
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    LessonId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "application",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "character varying(4096)", maxLength: 4096, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sources_Units_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "application",
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                schema: "application",
                columns: table => new
                {
                    UnitId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_Tasks_Units_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "application",
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Courses",
                columns: new[] { "Id", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1L, "Grammar", 1 },
                    { 2L, "Vocabulary", 2 },
                    { 3L, "Listening", 3 },
                    { 4L, "Speaking", 4 }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Levels",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1L, "A1", "Beginner" },
                    { 2L, "A2", "Elementary" },
                    { 3L, "B1", "Intermediate" },
                    { 4L, "B2", "Upper Intermediate" },
                    { 5L, "C1", "Advanced" },
                    { 6L, "C2", "Proficient" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Groups",
                columns: new[] { "Id", "CourseId", "Name", "SortOrder", "Token" },
                values: new object[,]
                {
                    { 1L, 1L, "Present simple", 1, "Grammar_PresentSimple" },
                    { 2L, 1L, "Present continuous", 2, "Grammar_PresentContinuous" },
                    { 3L, 1L, "Present simple or present continuous", 3, "Grammar_PresentSimpleOrPresentContinuous" },
                    { 4L, 1L, "Past simple", 4, "Grammar_PastSimple" },
                    { 5L, 1L, "Present perfect", 5, "Grammar_PresentPerfect" },
                    { 6L, 1L, "Past simple or Present perfect", 6, "Grammar_PastSimpleOrPresentPerfect" },
                    { 7L, 1L, "Past continuous", 7, "Grammar_PastContinuous" },
                    { 8L, 1L, "Future simple", 8, "Grammar_FutureSimple" },
                    { 9L, 1L, "Future forms", 9, "Grammar_FutureForms" },
                    { 10L, 1L, "Modal verbs", 10, "Grammar_ModalVerbs" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Lessons",
                columns: new[] { "Id", "Description", "GroupToken", "LevelId", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 1L, "Present Simple Lesson - A1", "Grammar_PresentSimple", 1L, 1, "Lesson" },
                    { 2L, "Present Continuous Lesson - A1", "Grammar_PresentContinuous", 1L, 2, "Lesson" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Units",
                columns: new[] { "Id", "LessonId", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, 1, "Present simple “to be”" },
                    { 2L, 1L, 2, "Present simple “do/does”" },
                    { 3L, 2L, 1, "Present Continuous. Rules" },
                    { 4L, 2L, 2, "Present Continuous. How to Use It" }
                });

            migrationBuilder.InsertData(
                schema: "application",
                table: "Sources",
                columns: new[] { "Id", "Content", "SortOrder", "UnitId" },
                values: new object[,]
                {
                    { new Guid("0bb399c5-f6c0-477e-bfe1-2804d8727e9d"), "Present continuous - настоящее длительное время, оно употребляется когда говорим о действиях которые происходит сейчас, на данный момент времени.", 1, 3L },
                    { new Guid("0dd61d36-e81a-4f83-a6a2-1c1a83dd2bb0"), "Слова-маркеры: \r\n\r\n	This/next week (на этой/следующей неделе)\r\n	Tonight (вечером)\r\n	Today (сегодня)\r\n	Tomorrow (завтра)\r\n	This/next year (в этом/следующем году)\r\n	This/next weekend (в эти/следующие выходные).", 5, 3L },
                    { new Guid("1c4e2bc5-5681-474f-90b1-f3ef51cb5dbb"), "Как переводится to be и когда используется?\r\n\r\n    'Be' мы используем в 3 случаях, когда мы хотим сказать:\r\n        Кто/что кем/чем является (она медсестра);\r\n        Кто/что каким является (мой кот серый);\r\n        Кто/что где находится (папа на работе).\r\n\r\n    То есть если мы хотим описать местоположение чего-либо, состояние чего-либо или то, чем является этот предмет/человек, то мы используем глагол to be.", 1, 1L },
                    { new Guid("1d63620a-5fb9-4714-aed2-9751e0d20bc2"), "Например: \r\n	I am meeting with Daniel tomorrow. \r\n	Здесь в этом предложении соответсвенно показано, что встреча запланирована!", 6, 3L },
                    { new Guid("33dc06e0-b57e-411f-a610-a2021310878b"), "Чтобы сделать вопросительное предложение \r\n\r\n    Do/ Does + Subject + Verb \r\n\r\n    Do you go to university?\r\n    Yes, I do \r\n    No, I don’t \r\n\r\n    Does he go swimming? \r\n    Yes, he does\r\n    No, he doesn’t", 5, 2L },
                    { new Guid("3e5a6c0b-ed10-442e-a816-4052b195b876"), "I go to work/university every day \r\n\r\nТакже оно употребляется, когда мы говорим про факты в настоящем.\r\n\r\nI like pizza/sushi", 2, 2L },
                    { new Guid("58d8f22c-e0ff-44d3-91e3-73c0d8ecd651"), "Здесь могут стоять ключевые слова такие как: now/ right now/ at the momen", 2, 3L },
                    { new Guid("59919315-546e-4e77-83ef-d4cb0750923f"), "Отрицательные предложения\r\n\r\n	1.	Формула: I am not + глагол-ing.\r\n		Пример: I am not singing - Я не пою.\r\n\r\n	2.	Формула: He/She/It is not + глагол-ing\r\n		Примеры:\r\n			He is not smiling - Он не улыбается. \r\n			She is not dancing - Она не танцует.\r\n			It is not shining - Оно не светит.\r\n\r\n	3.	Формула: We/You/They are not + глагол-ing.\r\n		Примеры: \r\n			We are not listening - Мы не слушаем.\r\n			You are not reading - Вы не читаете.\r\n			They are not swimming - Они не плавают.", 4, 3L },
                    { new Guid("5a43d4f2-9533-426a-b7f8-0797c0afcb72"), "Present simple - это простое настоящее время, оно употребляется когда говорим о действиях которые мы делаем регулярно, каждый или часто. Одним словом это действия который не заканчивается.", 1, 2L },
                    { new Guid("5bdcd04b-927f-4cb4-add0-e26c5f08183f"), "Таким образом мы описали ее внешность, и ее действия", 3, 3L },
                    { new Guid("63441e6e-ed53-460b-967e-7195731acc3a"), "Важно знать, как глагол to be меняется в зависимости от того, кто производит действие. Это можете быть вы, ваш друг или группа людей. В настоящем времени этот глагол имеет три формы: am, is, are. ", 2, 1L },
                    { new Guid("7063f525-5082-46fa-8ac7-32b59736255c"), " Единственное число\r\n    I am a doctor. Я являюсь доктором.\r\n    He is clever. Он является умным.\r\n    She is at home. Она находится дома.\r\n    It is an interesting book. Это есть интересная книга.\r\n    You are a smart guy. Ты являешься сообразительным парнем.", 4, 1L },
                    { new Guid("7f5f6f7f-efc0-401d-b873-22824efaf9ac"), "Например: \r\n	She is wearing a black dress.\r\n	She is smiling in the picture", 2, 3L },
                    { new Guid("84bcdb84-f67a-4fce-ace3-52c4462e1fd7"), "Следующий случай употребление времени «present continuous» - это когда говорим о запланированных и обязательно происходящих событий в ближайшем будущем", 4, 3L },
                    { new Guid("8ad43f4d-c6fe-4a96-a82d-f53633c17a60"), "В отрицательных предложениях\r\n\r\n    do + not - don’t\r\n    does + not - doesn’t\r\n\r\n    Subject + don’t/doesn’t + Verb\r\n\r\n    I don’t like ice cream \r\n    She doesn’t go to school", 4, 2L },
                    { new Guid("95ab912e-a522-4ce6-bcfa-b6bd39ccc090"), "Давайте рассмотрим примеры употребления. ", 3, 1L },
                    { new Guid("c84efae8-8385-402b-a613-95370fe925f2"), "Конструкция предложений в present simple \r\n\r\n    Subject + Verb\r\n    You like ice cream\r\n\r\n    He / She / It + Verb(s)\r\n    He likes ice cream", 3, 2L },
                    { new Guid("ce79ef45-afd2-4e2a-8d1e-5175ed1919b7"), " Множественное число \r\n    We are good singers. Мы являемся хорошими певцами. \r\n    You are wonderful listeners. Вы являетесь отличными слушателями. \r\n    They are in the room. Они находятся в комнате.", 5, 1L },
                    { new Guid("d495acb7-55a7-4139-a69e-bccdc6f5d8e8"), "Конструкция предложения\r\n\r\n	1.	Формула: I am + глагол-ing.\r\n		Пример: I am singing - Я пою.\r\n\r\n	2.	Формула: He/She/It is + глагол-ing.\r\n		Примеры: \r\n			He is smiling — Он улыбается.\r\n			She is dancing — Она танцует.\r\n			It is shining — Оно светит.\r\n\r\n	3.	Формула: We/You/They are + глагол-ing.\r\n		Примеры: \r\n			We are listening — Мы слушаем.\r\n			You are reading — Вы читаете.\r\n			They are swimming — Они плавают.\r\n\r\n	1.	Глагол заканчивается на —е \r\n		Правило: последняя буква отбрасывается \r\n		Пример: make — making (делать)\r\n\r\n	2.	Глагол оканчивается на —ie\r\n		Правило: -ie заменяется на -y\r\n		Пример: lie — lying (лежать)\r\n\r\n	3.	Односложный глагол, оканчивающийся на гласную с согласной\r\n		Правило: последняя согласная удваивается\r\n		Пример: get — getting (получать)", 3, 3L },
                    { new Guid("e5685327-4a26-4031-bea9-75b1bc2dba82"), "Present continuous - также мы можем использовать когда описываем, \r\nкакое то действие или же фото, так как описание происходит сейчас, \r\nмы должны соответсвенно использовать время «present continuous»", 1, 3L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CourseId",
                schema: "application",
                table: "Groups",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Token",
                schema: "application",
                table: "Groups",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupToken_SortOrder",
                schema: "application",
                table: "Lessons",
                columns: new[] { "GroupToken", "SortOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LevelId",
                schema: "application",
                table: "Lessons",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Code",
                schema: "application",
                table: "Levels",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sources_UnitId",
                schema: "application",
                table: "Sources",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_LessonId",
                schema: "application",
                table: "Units",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups",
                schema: "application");

            migrationBuilder.DropTable(
                name: "Sources",
                schema: "application");

            migrationBuilder.DropTable(
                name: "Tasks",
                schema: "application");

            migrationBuilder.DropTable(
                name: "Courses",
                schema: "application");

            migrationBuilder.DropTable(
                name: "Units",
                schema: "application");

            migrationBuilder.DropTable(
                name: "Lessons",
                schema: "application");

            migrationBuilder.DropTable(
                name: "Levels",
                schema: "application");
        }
    }
}
