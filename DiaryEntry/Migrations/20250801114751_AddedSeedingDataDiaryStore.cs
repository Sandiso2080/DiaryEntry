using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryEntry.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[] { 1, "Went Hiking with Msane", new DateTime(2025, 8, 1, 13, 47, 51, 1, DateTimeKind.Local).AddTicks(1847), "Went Hiking" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
