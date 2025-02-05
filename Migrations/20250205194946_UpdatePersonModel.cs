using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCrud.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "People",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            // Adicionando a conversão manual da coluna "Id" para uuid
            migrationBuilder.Sql("ALTER TABLE \"People\" ALTER COLUMN \"Id\" TYPE uuid USING \"Id\"::uuid;");

            migrationBuilder.AddColumn<bool>(
                name: "Isactive",
                table: "People",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isactive",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "People",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "People",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");
        }
    }
}