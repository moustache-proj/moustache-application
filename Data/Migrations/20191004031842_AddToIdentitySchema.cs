using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoustacheApp.Data.Migrations
{
    public partial class AddToIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "AltName",
                table: "AspNetUsers",
                type: "varchar(256)",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "Anonymous",
                table: "AspNetUsers",
                nullable: false,
                defaultValueSql: "'0'");

            migrationBuilder.AddColumn<DateTime>(
                name: "DisableDate",
                table: "AspNetUsers",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "Disabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValueSql: "'0'");

            migrationBuilder.AddColumn<string>(
                name: "DisabledBy",
                table: "AspNetUsers",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "varchar(256)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DisabledBy",
                table: "AspNetUsers",
                column: "DisabledBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_DisabledBy",
                table: "AspNetUsers",
                column: "DisabledBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_DisabledBy",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DisabledBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AltName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Anonymous",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DisableDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Disabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DisabledBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
