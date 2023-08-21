using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_EX1_DAY30.Migrations
{
    /// <inheritdoc />
    public partial class ProdMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInfo",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CompanyI__C1F8DC39EA77E54C", x => x.CId);
                });

            migrationBuilder.CreateTable(
                name: "ProductInfo",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PPrice = table.Column<double>(type: "float", nullable: true),
                    PMDate = table.Column<DateTime>(type: "date", nullable: true),
                    CId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductI__C577554057EAAFB5", x => x.PId);
                    table.ForeignKey(
                        name: "FK__ProductInfo__CId__398D8EEE",
                        column: x => x.CId,
                        principalTable: "CompanyInfo",
                        principalColumn: "CId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfo_CId",
                table: "ProductInfo",
                column: "CId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInfo");

            migrationBuilder.DropTable(
                name: "CompanyInfo");
        }
    }
}
