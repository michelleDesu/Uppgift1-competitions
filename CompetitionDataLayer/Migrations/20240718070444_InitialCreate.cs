using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompetitionDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("453294c3-3497-4d60-af9a-fcd176bde7ee"), "Tennis" },
                    { new Guid("a56bdd04-adfd-4c24-9750-1ebeacbd3ab7"), "fotboll" },
                    { new Guid("d111e3bf-6ec5-4b16-acef-175b4b64d9bc"), "Simmning" },
                    { new Guid("dcace436-7464-4db0-b217-0aa9178b28c3"), "Dans" },
                    { new Guid("e2c4e149-e541-4f3b-8d17-4f66277ea0a4"), "E-Sport" }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "CompetitionId", "Name" },
                values: new object[,]
                {
                    { new Guid("144ef59b-82d7-4db2-988e-d7cbe4adf8bb"), new Guid("d111e3bf-6ec5-4b16-acef-175b4b64d9bc"), "Saxe" },
                    { new Guid("1ab6c293-ea80-404b-997d-bfd63c4c064c"), new Guid("dcace436-7464-4db0-b217-0aa9178b28c3"), "Gisle" },
                    { new Guid("4493a978-3df2-4f74-bf34-68d1fd941a8d"), new Guid("a56bdd04-adfd-4c24-9750-1ebeacbd3ab7"), "Estrid" },
                    { new Guid("4c5f5fe8-26cd-4ee3-923c-9ecb54744c5c"), new Guid("dcace436-7464-4db0-b217-0aa9178b28c3"), "Haldur" },
                    { new Guid("50239484-3d3c-4c33-a3f3-b5cd1170e8c3"), new Guid("e2c4e149-e541-4f3b-8d17-4f66277ea0a4"), "Embla" },
                    { new Guid("6945876f-a8f5-4fab-9a67-b460e6a0bbe0"), new Guid("e2c4e149-e541-4f3b-8d17-4f66277ea0a4"), "Ulv" },
                    { new Guid("71b818d9-1090-44c3-b211-9f12daed903b"), new Guid("a56bdd04-adfd-4c24-9750-1ebeacbd3ab7"), "Erling" },
                    { new Guid("a9e7045e-d9e5-452a-8d7d-2e51f5b55137"), new Guid("453294c3-3497-4d60-af9a-fcd176bde7ee"), "Torgny" },
                    { new Guid("df40ce10-6c3f-4b58-b3e5-fdd6b20cde88"), new Guid("dcace436-7464-4db0-b217-0aa9178b28c3"), "Erak" },
                    { new Guid("f399a73f-c5d9-4cb0-83a3-e0e9d9e8ce6d"), new Guid("e2c4e149-e541-4f3b-8d17-4f66277ea0a4"), "Saga" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_CompetitionId",
                table: "Participants",
                column: "CompetitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Competitions");
        }
    }
}
