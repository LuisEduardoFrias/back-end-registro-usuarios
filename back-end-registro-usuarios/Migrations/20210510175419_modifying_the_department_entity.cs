using Microsoft.EntityFrameworkCore.Migrations;

namespace UserRegistration.Api.Migrations
{
    public partial class modifying_the_department_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "DepartmentId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DepartmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Users");

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
    }
}
