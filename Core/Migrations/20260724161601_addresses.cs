using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class addresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 370, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 372, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 24, 18, 15, 54, 373, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 23, 23, 57, 44, 840, DateTimeKind.Local).AddTicks(3166));
        }
    }
}
