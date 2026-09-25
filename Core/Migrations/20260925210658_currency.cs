using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class currency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecimalPlaces = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedDateTime", "DecimalPlaces", "DeletedDateTime", "IsDeleted", "ModifiedDateTime", "Name", "Symbol" },
                values: new object[,]
                {
                    { 1, "EUR", new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7534), 2, null, false, null, "Euro", "€" },
                    { 2, "USD", new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7545), 2, null, false, null, "Dollar", "$" },
                    { 3, "BAM", new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7550), 2, null, false, null, "Konvertibilna marka", "KM" },
                    { 4, "RSD", new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7555), 2, null, false, null, "Srpski dinar", "din." }
                });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 23, 6, 55, 402, DateTimeKind.Local).AddTicks(7120));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "BusinessTypes",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 558, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "MessageUsReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDateTime",
                value: new DateTime(2026, 9, 25, 18, 57, 6, 559, DateTimeKind.Local).AddTicks(625));
        }
    }
}
