using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestingApp.Data.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestAppRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Issue_Number = table.Column<int>(type: "int", nullable: false),
                    Client_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Issue_Type = table.Column<int>(type: "int", nullable: false),
                    Assigned_Developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assigned_Tester = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cycle_Count = table.Column<int>(type: "int", nullable: false),
                    Date_Per_Cycle_Count = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestAppRecord", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestAppRecord");
        }
    }
}
