using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class ConvertStringToNoteNavigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Activities");

            migrationBuilder.AddColumn<Guid>(
                name: "ActivityId",
                table: "Notes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "ActivityId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ActivityId",
                table: "Notes",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Activities_ActivityId",
                table: "Notes",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Activities_ActivityId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_ActivityId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Notes");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "Notes",
                value: null);
        }
    }
}
