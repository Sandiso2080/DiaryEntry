using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryEntry.Migrations
{
    /// <inheritdoc />
    public partial class addSeedDiaryEntryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 8, 1, 13, 53, 17, 611, DateTimeKind.Local).AddTicks(4637));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 8, 1, 13, 47, 51, 1, DateTimeKind.Local).AddTicks(1847));
        }
    }
}
