using Microsoft.EntityFrameworkCore.Migrations;

namespace UserRegistration.Api.Migrations
{
    public partial class modified_users_entity_birt_Day_and_last_name_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LasName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "DateBirth",
                table: "Users",
                newName: "BirthDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "LasName");

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Users",
                newName: "DateBirth");
        }
    }
}
