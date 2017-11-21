using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CharityApp.Data.Migrations
{
    public partial class version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_News_NewsId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_NewsId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Categories");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_NewsId",
                table: "Categories",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_News_NewsId",
                table: "Categories",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
