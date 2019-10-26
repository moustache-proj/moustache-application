using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoustacheApp.Data.Migrations
{
    public partial class AddAuditHandling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MoQuizUser",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "MoQuizUser",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MoQuizUser",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "MoQuizUser",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MoQuizOwner",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "MoQuizOwner",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MoQuizOwner",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "MoQuizOwner",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MoQuizDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "MoQuizDetail",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MoQuizDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "MoQuizDetail",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MoQuestion",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "MoQuestion",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MoQuestion",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "MoQuestion",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MoPlayResult",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "MoPlayResult",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MoPlayResult",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "MoPlayResult",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MoAnswer",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "MoAnswer",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MoAnswer",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "MoAnswer",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MoQuizUser");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MoQuizUser");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MoQuizUser");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MoQuizUser");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MoQuizOwner");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MoQuizOwner");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MoQuizOwner");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MoQuizOwner");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MoQuizDetail");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MoQuizDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MoQuizDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MoQuizDetail");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MoQuestion");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MoQuestion");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MoQuestion");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MoQuestion");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MoPlayResult");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MoPlayResult");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MoPlayResult");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MoPlayResult");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MoAnswer");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MoAnswer");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MoAnswer");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MoAnswer");
        }
    }
}
