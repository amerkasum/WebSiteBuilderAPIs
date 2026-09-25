using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class userResidence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserResidences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResidences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserResidences_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserResidences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 849, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 0, 12, 42, 850, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.CreateIndex(
                name: "IX_UserResidences_AddressId",
                table: "UserResidences",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResidences_UserId",
                table: "UserResidences",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserResidences");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 23, 0, 31, 47, 120, DateTimeKind.Local).AddTicks(5226));
        }
    }
}
