using Microsoft.EntityFrameworkCore.Migrations;

namespace UserRegistration.Api.Migrations
{
    public partial class modifying_the_user_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Users_Department",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Department",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentCode",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentCode",
                table: "Users",
                column: "DepartmentCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentCode",
                table: "Users",
                column: "DepartmentCode",
                principalTable: "Departments",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentCode",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DepartmentCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DepartmentCode",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Department",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Department",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Department",
                table: "Departments",
                column: "Department");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Users_Department",
                table: "Departments",
                column: "Department",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
