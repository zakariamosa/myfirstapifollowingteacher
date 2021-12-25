using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myFirstRESTApi.Migrations
{
    public partial class dummy_data_for_artist_and_vinyls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "FavoriteCar", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7182), "BMW", "Amr Diab" },
                    { 2, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7276), "Mercedes", "mohammed fouad" },
                    { 3, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7281), "Tesla", "Mostafa amar" },
                    { 4, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7283), "Rols", "Hamaky" }
                });

            migrationBuilder.InsertData(
                table: "Vinyls",
                columns: new[] { "Id", "ArtistID", "Created", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7381), "tammaly maaaak" },
                    { 2, 1, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7384), "esmaaaa" },
                    { 3, 2, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7386), "ahkilak" },
                    { 4, 3, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7388), "vinyl3" },
                    { 5, 3, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7390), "ya habibi" },
                    { 6, 4, new DateTime(2021, 12, 15, 1, 36, 13, 35, DateTimeKind.Local).AddTicks(7392), "ellylady" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vinyls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
