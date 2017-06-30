using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DynamicCv.Web.Migrations
{
    public partial class Adduserasalevelconnectedusertoentry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Entrys",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CvUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    About = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    UserLogin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrys_UserId",
                table: "Entrys",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrys_CvUser_UserId",
                table: "Entrys",
                column: "UserId",
                principalTable: "CvUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrys_CvUser_UserId",
                table: "Entrys");

            migrationBuilder.DropTable(
                name: "CvUser");

            migrationBuilder.DropIndex(
                name: "IX_Entrys_UserId",
                table: "Entrys");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Entrys");
        }
    }
}
