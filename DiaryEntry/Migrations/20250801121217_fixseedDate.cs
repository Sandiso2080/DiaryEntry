using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryEntry.Migrations
{
    /// <inheritdoc />
    public partial class fixseedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 8, 1, 13, 57, 15, 39, DateTimeKind.Local).AddTicks(8640));
        }
    }
}
