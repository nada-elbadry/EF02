using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tryy01.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableWithFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "EmployeeTable");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "EmployeeTable",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(10,2)");

            migrationBuilder.AlterColumn<int>(
                name: "EmpId",
                table: "EmployeeTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddCheckConstraint(
                name: "Check_Employee_Email",
                table: "EmployeeTable",
                sql: "[Email] like '%@%.%'");

            migrationBuilder.AddCheckConstraint(
                name: "Check-Employee-Age-Range",
                table: "EmployeeTable",
                sql: "[Age] Between 22 And 40");

            migrationBuilder.AddCheckConstraint(
                name: "CheckAllowed_Employee_Age",
                table: "EmployeeTable",
                sql: "[Age] IN (24,26,28,30)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Check_Employee_Email",
                table: "EmployeeTable");

            migrationBuilder.DropCheckConstraint(
                name: "Check-Employee-Age-Range",
                table: "EmployeeTable");

            migrationBuilder.DropCheckConstraint(
                name: "CheckAllowed_Employee_Age",
                table: "EmployeeTable");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "EmployeeTable",
                type: "DECIMAL(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "EmpId",
                table: "EmployeeTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
