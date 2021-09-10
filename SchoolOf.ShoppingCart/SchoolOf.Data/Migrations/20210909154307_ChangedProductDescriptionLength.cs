using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolOf.Data.Migrations
{
    public partial class ChangedProductDescriptionLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 239, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 239, DateTimeKind.Unspecified).AddTicks(6113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 239, DateTimeKind.Unspecified).AddTicks(6616), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 239, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 239, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 239, DateTimeKind.Unspecified).AddTicks(6625), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 9, 15, 23, 38, 846, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 9, 15, 23, 38, 846, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 9, 15, 23, 38, 846, DateTimeKind.Unspecified).AddTicks(5695), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 9, 15, 23, 38, 846, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 9, 15, 23, 38, 846, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 9, 15, 23, 38, 846, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
