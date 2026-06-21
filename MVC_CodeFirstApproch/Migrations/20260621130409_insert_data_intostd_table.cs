using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_CodeFirstApproch.Migrations
{
    /// <inheritdoc />
    public partial class insert_data_intostd_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentInformations",
                columns: new[] { "Id", "Address", "Age", "DOB", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main St, Cityville", 20, new DateOnly(2003, 5, 15), "Male", "John Doe" },
                    { 2, "456 Elm St, Townsville", 22, new DateOnly(2001, 8, 10), "Female", "Jane Smith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentInformations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentInformations",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
