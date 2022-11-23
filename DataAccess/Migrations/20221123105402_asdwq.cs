using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class asdwq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterTime",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 863, DateTimeKind.Local).AddTicks(9375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 933, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Product",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(6375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 931, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(6202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 931, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Meal",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(1726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 930, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Meal",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(1498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 930, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserName", "BirthDate", "PasswordHash", "UserClaim" },
                values: new object[] { "admin", new DateTime(2022, 11, 23, 13, 54, 1, 864, DateTimeKind.Local).AddTicks(169), new byte[] { 140, 105, 118, 229, 181, 65, 4, 21, 189, 233, 8, 189, 77, 238, 21, 223, 177, 103, 169, 200, 115, 252, 75, 184, 168, 31, 111, 42, 180, 72, 169, 24 }, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserName",
                keyValue: "admin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterTime",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 933, DateTimeKind.Local).AddTicks(8034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 863, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Product",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 931, DateTimeKind.Local).AddTicks(2306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 931, DateTimeKind.Local).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Meal",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 930, DateTimeKind.Local).AddTicks(7550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Meal",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 23, 10, 58, 59, 930, DateTimeKind.Local).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 23, 13, 54, 1, 861, DateTimeKind.Local).AddTicks(1498));
        }
    }
}
