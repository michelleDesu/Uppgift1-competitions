using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompetitionDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatetests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("144ef59b-82d7-4db2-988e-d7cbe4adf8bb"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("1ab6c293-ea80-404b-997d-bfd63c4c064c"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("4493a978-3df2-4f74-bf34-68d1fd941a8d"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("4c5f5fe8-26cd-4ee3-923c-9ecb54744c5c"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("50239484-3d3c-4c33-a3f3-b5cd1170e8c3"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("6945876f-a8f5-4fab-9a67-b460e6a0bbe0"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("71b818d9-1090-44c3-b211-9f12daed903b"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("a9e7045e-d9e5-452a-8d7d-2e51f5b55137"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("df40ce10-6c3f-4b58-b3e5-fdd6b20cde88"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("f399a73f-c5d9-4cb0-83a3-e0e9d9e8ce6d"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("453294c3-3497-4d60-af9a-fcd176bde7ee"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("a56bdd04-adfd-4c24-9750-1ebeacbd3ab7"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("d111e3bf-6ec5-4b16-acef-175b4b64d9bc"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("dcace436-7464-4db0-b217-0aa9178b28c3"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("e2c4e149-e541-4f3b-8d17-4f66277ea0a4"));

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("668b7ad2-977c-4025-a738-e3cd2232dfcf"), "fotboll" },
                    { new Guid("91077f23-927e-43b2-9bac-7af409a06282"), "Tennis" },
                    { new Guid("97beff8c-3a08-4c88-85d3-70de1853297a"), "Dans" },
                    { new Guid("b794e9a2-3fa8-4041-a948-034189216bbd"), "E-sport" },
                    { new Guid("ea9c3f9b-957a-4ec3-bb40-3327c5a08f1b"), "Simmning" }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "CompetitionId", "Name" },
                values: new object[,]
                {
                    { new Guid("02c6926b-3445-4a27-92fd-7c1e62168c38"), new Guid("b794e9a2-3fa8-4041-a948-034189216bbd"), "Saga" },
                    { new Guid("161ea10f-c77b-45b9-b4d5-7d5808fb27de"), new Guid("668b7ad2-977c-4025-a738-e3cd2232dfcf"), "Erling" },
                    { new Guid("2eaf5367-04cf-4222-bb6e-794c8ed5c2c9"), new Guid("97beff8c-3a08-4c88-85d3-70de1853297a"), "Haldur" },
                    { new Guid("51d87b0c-573d-4664-a385-937436fced10"), new Guid("97beff8c-3a08-4c88-85d3-70de1853297a"), "Gisle" },
                    { new Guid("52b5988d-e1fa-4010-af9d-631a3584c9bc"), new Guid("b794e9a2-3fa8-4041-a948-034189216bbd"), "Embla" },
                    { new Guid("545ba864-36a8-40f9-9445-52df6fddcbd7"), new Guid("b794e9a2-3fa8-4041-a948-034189216bbd"), "Ulv" },
                    { new Guid("803d7cc5-a497-4d56-910a-0a4943a6cfee"), new Guid("91077f23-927e-43b2-9bac-7af409a06282"), "Torgny" },
                    { new Guid("83ff27a9-916a-4001-8bd9-ec12ba46dc9b"), new Guid("97beff8c-3a08-4c88-85d3-70de1853297a"), "Erak" },
                    { new Guid("e57e164c-3e23-4740-a0a0-4eeb0367c02f"), new Guid("ea9c3f9b-957a-4ec3-bb40-3327c5a08f1b"), "Saxe" },
                    { new Guid("e6199131-33d1-413c-aa3f-30637c8cd0cb"), new Guid("668b7ad2-977c-4025-a738-e3cd2232dfcf"), "Estrid" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("02c6926b-3445-4a27-92fd-7c1e62168c38"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("161ea10f-c77b-45b9-b4d5-7d5808fb27de"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("2eaf5367-04cf-4222-bb6e-794c8ed5c2c9"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("51d87b0c-573d-4664-a385-937436fced10"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("52b5988d-e1fa-4010-af9d-631a3584c9bc"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("545ba864-36a8-40f9-9445-52df6fddcbd7"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("803d7cc5-a497-4d56-910a-0a4943a6cfee"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("83ff27a9-916a-4001-8bd9-ec12ba46dc9b"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("e57e164c-3e23-4740-a0a0-4eeb0367c02f"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("e6199131-33d1-413c-aa3f-30637c8cd0cb"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("668b7ad2-977c-4025-a738-e3cd2232dfcf"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("91077f23-927e-43b2-9bac-7af409a06282"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("97beff8c-3a08-4c88-85d3-70de1853297a"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("b794e9a2-3fa8-4041-a948-034189216bbd"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: new Guid("ea9c3f9b-957a-4ec3-bb40-3327c5a08f1b"));

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("453294c3-3497-4d60-af9a-fcd176bde7ee"), "Tennis" },
                    { new Guid("a56bdd04-adfd-4c24-9750-1ebeacbd3ab7"), "fotboll" },
                    { new Guid("d111e3bf-6ec5-4b16-acef-175b4b64d9bc"), "Simmning" },
                    { new Guid("dcace436-7464-4db0-b217-0aa9178b28c3"), "Dans" },
                    { new Guid("e2c4e149-e541-4f3b-8d17-4f66277ea0a4"), "E-sport" }
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
        }
    }
}
