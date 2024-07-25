using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedUnits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("0bb399c5-f6c0-477e-bfe1-2804d8727e9d"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("0dd61d36-e81a-4f83-a6a2-1c1a83dd2bb0"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("1c4e2bc5-5681-474f-90b1-f3ef51cb5dbb"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("1d63620a-5fb9-4714-aed2-9751e0d20bc2"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("33dc06e0-b57e-411f-a610-a2021310878b"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("3e5a6c0b-ed10-442e-a816-4052b195b876"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("58d8f22c-e0ff-44d3-91e3-73c0d8ecd651"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("59919315-546e-4e77-83ef-d4cb0750923f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5a43d4f2-9533-426a-b7f8-0797c0afcb72"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("5bdcd04b-927f-4cb4-add0-e26c5f08183f"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("63441e6e-ed53-460b-967e-7195731acc3a"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("7063f525-5082-46fa-8ac7-32b59736255c"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("7f5f6f7f-efc0-401d-b873-22824efaf9ac"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("84bcdb84-f67a-4fce-ace3-52c4462e1fd7"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("8ad43f4d-c6fe-4a96-a82d-f53633c17a60"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("95ab912e-a522-4ce6-bcfa-b6bd39ccc090"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("c84efae8-8385-402b-a613-95370fe925f2"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("ce79ef45-afd2-4e2a-8d1e-5175ed1919b7"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("d495acb7-55a7-4139-a69e-bccdc6f5d8e8"));

            migrationBuilder.DeleteData(
                schema: "application",
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("e5685327-4a26-4031-bea9-75b1bc2dba82"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
