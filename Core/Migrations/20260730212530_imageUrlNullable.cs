using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class imageUrlNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "Id", "Code", "CreatedDateTime", "DeletedDateTime", "IsDeleted", "ModifiedDateTime", "Name" },
                values: new object[,]
                {
                    { 1, "EMAIL", new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8771), null, false, null, "Email" },
                    { 2, "PHONE_NUMBER", new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8781), null, false, null, "Phonenumber" }
                });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 30, 23, 25, 26, 931, DateTimeKind.Local).AddTicks(8412));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 7, 29, 19, 7, 8, 883, DateTimeKind.Local).AddTicks(432));

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
        }
    }
}
