using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crop",
                columns: table => new
                {
                    CropId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    CropName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HervestDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crop", x => x.CropId);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    ExpensesId = table.Column<int>(type: "int", nullable: false),
                    FarmId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpensesType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpensesAmount = table.Column<int>(type: "int", nullable: false),
                    ExpensesDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Farm",
                columns: table => new
                {
                    FarmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.FarmId);
                });

            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    IncomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    IncomeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.IncomeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crop");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "Farm");

            migrationBuilder.DropTable(
                name: "Income");
        }
    }
}
