using Microsoft.EntityFrameworkCore.Migrations;

namespace RepoDemo.Business.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "sarah@example.com", "Sarah", 635578892 },
                    { 2, "burt@example.com", "Burt", 635578893 },
                    { 3, "devon@example.com", "Devon", 635578894 },
                    { 4, "oprah@example.com", "Oprah", 635578895 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
