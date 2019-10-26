using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoustacheApp.Data.Migrations
{
    public partial class CreateMoustacheSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "MoQuizDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    PreviousId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Current = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    CommonId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Information = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    Published = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    Attempts = table.Column<uint>(nullable: false, defaultValueSql: "'1'"),
                    Played = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    Randomise = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    QuestToPlay = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    QuizStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeLimit = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    ResultLocked = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    LockedUntil = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoQuizDetail", x => x.Id);
                    table.ForeignKey(
                        name: "MoQuizDetail_ibfk_1",
                        column: x => x.PreviousId,
                        principalTable: "MoQuizDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoPlayResult",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    QuizId = table.Column<string>(type: "varchar(255)", nullable: false),
                    PlayedDT = table.Column<DateTime>(type: "datetime", nullable: false),
                    SubmittedDT = table.Column<DateTime>(type: "datetime", nullable: false),
                    Attempt = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    QuestCount = table.Column<uint>(nullable: false, defaultValueSql: "'0'"),
                    Result = table.Column<uint>(nullable: true),
                    ResultAdjusted = table.Column<uint>(nullable: true),
                    Feedback = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoPlayResult", x => x.Id);
                    table.ForeignKey(
                        name: "MoPlayResult_ibfk_1",
                        column: x => x.QuizId,
                        principalTable: "MoQuizDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoQuestion",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    QuizId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Question = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "MoQuestion_ibfk_1",
                        column: x => x.QuizId,
                        principalTable: "MoQuizDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoQuizOwner",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    QuizId = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoQuizOwner", x => x.Id);
                    table.ForeignKey(
                        name: "MoQuizOwner_ibfk_1",
                        column: x => x.QuizId,
                        principalTable: "MoQuizDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoQuizUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    QuizId = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoQuizUser", x => x.Id);
                    table.ForeignKey(
                        name: "MoQuizUser_ibfk_1",
                        column: x => x.QuizId,
                        principalTable: "MoQuizDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoAnswer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    QuestionId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: false),
                    Correct = table.Column<uint>(nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "MoAnswer_ibfk_1",
                        column: x => x.QuestionId,
                        principalTable: "MoQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "QuestionId",
                table: "MoAnswer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "QuizId",
                table: "MoPlayResult",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "QuizId",
                table: "MoQuestion",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "CommonId",
                table: "MoQuizDetail",
                column: "CommonId");

            migrationBuilder.CreateIndex(
                name: "PreviousId",
                table: "MoQuizDetail",
                column: "PreviousId");

            migrationBuilder.CreateIndex(
                name: "QuizId",
                table: "MoQuizOwner",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "UserId",
                table: "MoQuizOwner",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "QuizId",
                table: "MoQuizUser",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "UserId",
                table: "MoQuizUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoAnswer");

            migrationBuilder.DropTable(
                name: "MoPlayResult");

            migrationBuilder.DropTable(
                name: "MoQuizOwner");

            migrationBuilder.DropTable(
                name: "MoQuizUser");

            migrationBuilder.DropTable(
                name: "MoQuestion");

            migrationBuilder.DropTable(
                name: "MoQuizDetail");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");
        }
    }
}
