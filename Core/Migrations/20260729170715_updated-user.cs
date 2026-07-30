using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class updateduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 882, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Code", "CreatedDateTime", "DeletedDateTime", "IsDeleted", "ModifiedDateTime", "Name" },
                values: new object[,]
                {
                    { 1, "M", new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(419), null, false, null, "Male" },
                    { 2, "F", new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(428), null, false, null, "Female" },
                    { 3, "PNTS", new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(432), null, false, null, "Prefer not to say" }
                });

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Users_GenderId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Gender");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 27, 19, 55, 12, 187, DateTimeKind.Local).AddTicks(8001));
        }
    }
}
